import { HttpInterceptorFn } from '@angular/common/http';

export const myInterceptorInterceptor: HttpInterceptorFn = (req, next) => {
  debugger;
  if (!req.headers.has('Accept-Encoding')) {
    const modifiedReq = req.clone({
      setHeaders: {
        'Accept-Encoding': 'application/json',
      },
    });

    return next(modifiedReq);
  }

  return next(req);
};
