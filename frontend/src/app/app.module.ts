import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { environment } from '../environments/environment';

import {
  AuthModule,
  OidcSecurityService,
  OpenIDImplicitFlowConfiguration,
  OidcConfigService,
  AuthWellKnownEndpoints
} from 'angular-auth-oidc-client';


import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [AppComponent, HomeComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    AuthModule.forRoot(),
    AppRoutingModule
  ],
  providers: [
    OidcConfigService,
    {
      provide: APP_INITIALIZER,
      useFactory: (oidcConfigService: OidcConfigService) => () =>
        oidcConfigService.load_using_stsServer(environment.authSettings.stsServer),
      deps: [OidcConfigService],
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(
    private oidcSecurityService: OidcSecurityService,
    private oidcConfigService: OidcConfigService
  ) {
    this.oidcConfigService.onConfigurationLoaded.subscribe(() => {
      const openIDImplicitFlowConfiguration = new OpenIDImplicitFlowConfiguration();

      openIDImplicitFlowConfiguration.stsServer =
        environment.authSettings.stsServer;
      openIDImplicitFlowConfiguration.redirect_url =
        environment.authSettings.redirect_url;
      // The Client MUST validate that the aud (audience) Claim contains its client_id value registered at the Issuer
      // identified by the iss (issuer) Claim as an audience.
      // The ID Token MUST be rejected if the ID Token does not list the Client as a valid audience,
      // or if it contains additional audiences not trusted by the Client.
      openIDImplicitFlowConfiguration.client_id =
        environment.authSettings.client_id;
      openIDImplicitFlowConfiguration.response_type =
        environment.authSettings.response_type;
      openIDImplicitFlowConfiguration.scope = environment.authSettings.scope;
      openIDImplicitFlowConfiguration.post_logout_redirect_uri =
        environment.authSettings.post_logout_redirect_uri;
      openIDImplicitFlowConfiguration.start_checksession =
        environment.authSettings.start_checksession;
      openIDImplicitFlowConfiguration.silent_renew =
        environment.authSettings.silent_renew;
      openIDImplicitFlowConfiguration.silent_renew_url =
        environment.authSettings.silent_renew_url;
      openIDImplicitFlowConfiguration.post_login_route =
        environment.authSettings.startup_route;
      // HTTP 403
      openIDImplicitFlowConfiguration.forbidden_route =
        environment.authSettings.forbidden_route;
      // HTTP 401
      openIDImplicitFlowConfiguration.unauthorized_route =
        environment.authSettings.unauthorized_route;
      openIDImplicitFlowConfiguration.log_console_warning_active =
        environment.authSettings.log_console_warning_active;
      openIDImplicitFlowConfiguration.log_console_debug_active =
        environment.authSettings.log_console_debug_active;
      // id_token C8: The iat Claim can be used to reject tokens that were issued too far away from the current time,
      // limiting the amount of time that nonces need to be stored to prevent attacks.The acceptable range is Client specific.
      // tslint:disable-next-line:max-line-length
      openIDImplicitFlowConfiguration.max_id_token_iat_offset_allowed_in_seconds =
        environment.authSettings.max_id_token_iat_offset_allowed_in_seconds;

      // // openIDImplicitFlowConfiguration.iss_validation_off = false;
      // configuration.FileServer = this.oidcConfigService.clientConfiguration.apiFileServer;
      // configuration.Server = this.oidcConfigService.clientConfiguration.apiServer;

      const authWellKnownEndpoints = new AuthWellKnownEndpoints();
      authWellKnownEndpoints.setWellKnownEndpoints(
        this.oidcConfigService.wellKnownEndpoints
      );

      this.oidcSecurityService.setupModule(
        openIDImplicitFlowConfiguration,
        authWellKnownEndpoints
      );
    });
  }
}

