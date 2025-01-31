# HNG12 Public API

This is a simple ASP.NET Core Web API. It provides a public endpoint that returns JSON data containing the registered email, the current UTC datetime, and the GitHub repository URL.

## Features

- Returns email, current timestamp in ISO 8601 format, and GitHub URL.
- Supports CORS for cross-origin requests.
- Fast response time (<500ms).

## Technologies Used

- C# (.NET 6)
- ASP.NET Core Web API
- Hosted on ----

## API Documentation

### Endpoint

**GET /api/hng12**

### Response Format (200 OK)

```
sample
json 
{
  "email": "HNG@example.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/username/repo"
}
```

## Setup Instructions

### Prerequisites

- .NET SDK 6 installed
- Git installed

### Running Locally

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/your-repo.git
   cd your-repo
   ```
2. Run the application:
   ```sh
   dotnet run
   ```
3. The API will be available at `http://localhost:5000/api/hng12`

## Deployment

- The API is deployed at: `https://hngtaskzero-klj1.onrender.com/api/hng12`

## Additional Resources

- [HNG12 C# Developers](https://hng.tech/hire/csharp-developers)


