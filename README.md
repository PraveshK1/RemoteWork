This scaffolding project is designed to follow the naming convention and stucture below

IntegrationApi/
├── Controllers/
│   └── UsersController.cs
├── Models/
│   └── UserModel.cs
├── DTOs/
│   └── UserDTO.cs
├── Services/
│   ├── IUserService.cs
│   └── UserService.cs
├── Repositories/
│   ├── IUserRepository.cs
│   └── UserRepository.cs
├── Helpers/
│   └── ValidationHelper.cs
├── Extensions/
│   └── StringExtensions.cs
├── Configuration/
│   └── AppSettings.cs
├── Exceptions/
│   └── ApiException.cs
├── Middleware/
│   └── AuthenticationMiddleware.cs
├── Filters/
│   └── AuthorizationFilter.cs
├── Attributes/
│   └── AllowAnonymousAttribute.cs
├── Enums/
│   └── StatusEnum.cs
├── Libraries/
│   └── MyCustomLibrary.cs
├── Data/
│   └── AppDbContext.cs
├── Program.cs
└── IntegrationApi.csproj
