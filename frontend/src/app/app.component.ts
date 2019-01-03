import { Component, OnInit, OnDestroy } from '@angular/core';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import { filter, take } from 'rxjs/operators';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'app';
  token = '';
  constructor(public oidcSecurityService: OidcSecurityService) {
    this.oidcSecurityService.getIsModuleSetup().pipe(
      filter((isModuleSetup: boolean) => isModuleSetup),
      take(1)
    ).subscribe((isModuleSetup: boolean) => {
      this.doCallbackLogicIfRequired();
    });
  }

  ngOnInit() {
    this.oidcSecurityService.getUserinfo().subscribe(c => {

    }); }

  ngOnDestroy(): void { }

  login() {

    // if you need to add extra parameters to the login
    // let culture = 'de-CH';
    // this.oidcSecurityService.setCustomRequestParameters({ 'ui_locales': culture });

    this.oidcSecurityService.authorize();
  }

  logout() {
    this.oidcSecurityService.logoff();
  }

  private doCallbackLogicIfRequired() {
    if (window.location.hash) {
      this.oidcSecurityService.authorizedCallback();

    }
  }
}
