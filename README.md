# WebApiTokenAuth
WebAPI token Authenticaion with bearer authorization with ASP.NET Identity

Steps:
1. Run the application and click on Login button to register a user
2. Once a user is successfully register ASP.NET identity will create a local DB for user store
3. Token authentication can be tested as below:
    a. Issue a POST request through postman as http://(domainname)/token (copy the url from the browser) by sending the username and password in the body as "username=(uid)&password=(password)&grant_type=password -- here grant_type is very important to generate the token
    b. Once the token is generated, the token can be used to issue requests to WebApi as below
    c. The WebApi requests can be made using the token generated in the above step. This can be tested through Postman by adding Authorization header in the get request:

Key             Value
Authorization   Bearer (token generated in step 3.a.)
