// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  authSettings: {
    stsServer: 'https://localhost:5000',
    redirect_url: 'https://localhost:4200',
    client_id: 'frontend',
    response_type: 'id_token token',
    scope: 'dataEventRecords openid profile',
    post_logout_redirect_uri: 'https://localhost:4200',
    start_checksession: true,
    silent_renew: true,
    startup_route: '/home',
    forbidden_route: '/forbidden',
    unauthorized_route: '/unauthorized',
    log_console_warning_active: true,
    log_console_debug_active: true,
    max_id_token_iat_offset_allowed_in_seconds: 10,
    silent_renew_url: 'https://localhost:4200/assets/silent-renew.html'
  }
};

/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
