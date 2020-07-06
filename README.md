# Asp-Core-3-Cookie-Authentication
 Very simple cookie authentication in ASP.NET Core 3

In this example we'r going to demonstrate how a user is Authenticated and Authorized using Cookie based authentication.
We'll create the followings -

1. Claims
2. ClaimIdentity
3. ClaimPrincipal
4. Authorization

Create an Empty ASP.Net core 3 web application. We'll add related middleware and services on our own as and when needed.
In Startup.Configure() method, add the app.useAuthentication() & app.useAuthorization() middleware right after "app.UseRouting"

In ConfigureServices() method add authentication schema for cookies authentication. Assign action method in login path to which user will be authenticated.

In the Home controller, decorate one of the action method with [Authorize] attribute.

In the action method we which we added in cookie login path; create claims/claimidentity/claimprincipal.

Once we call HttpContext.SignInAsync() a new cookie is created and this means the user is now authenticated.
