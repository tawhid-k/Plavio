# SchedulingWizard - Course Scheduling Application

## Project Overview
SchedulingWizard is a Windows Forms application written in C# that helps manage and generate course schedules. The application appears to be designed for educational institutions to handle course scheduling and user management.

### Key Features
- User authentication system with admin and regular user roles
- Course management (add/drop courses)
- User management (add/drop users)
- Automated schedule generation
- Profile management
- Course conflict detection
- Multiple schedule combinations generation

## Getting Started

### Prerequisites
- Windows operating system
- .NET Framework
- SQL Server Express (The connection string points to `SQLEXPRESS` instance)
- Visual Studio (for development)

### Database Setup
1. Install SQL Server Express
2. Create a database named `csharpprojectdata`
3. The database should have the following tables:
   - `userinfo` (name, id, email, pass)
   - `courses` (id, name)
   - `timing` (cid, cname, sec, day, start, endt)
   - `selection` (id, name)
   - `enroll` (username)

### Running the Application

1. Clone/download the project
2. Open the solution in Visual Studio
3. Update the connection string in `database.cs` if needed:
```cs
string connectionString = "Data Source=TAWHID_PC\\SQLEXPRESS;Initial Catalog=csharpprojectdata;Integrated Security=True";
```
4. Build and run the project
5. The application starts with an options screen where you can:
   - Create a new account
   - Login to existing account
   - View application information

### User Types

#### Admin User
- Username: "Admin"
- Can add/remove users
- Can add/remove courses
- Can manage course schedules

#### Regular Users
- Can view available courses
- Can select courses
- Can generate possible schedules
- Can edit their profile
- Can view their information

### Basic Workflow
1. Login or create an account
2. View available courses
3. Select desired courses
4. Generate possible schedules
5. View and choose from generated schedule combinations

The application handles time conflicts automatically and presents only valid schedule combinations to users.
