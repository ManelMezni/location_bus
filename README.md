# Bus Rental Manager (Location Bus)

A Windows desktop application for managing a bus rental agency's fleet and rental contracts, built with C# WinForms and SQL Server.

## Features
- **Fleet management**: add buses (registration plate, brand, purchase date, capacity, purchase price, daily rental price) and search by seating capacity
- **Rental management**: create a rental by picking a bus, a client, and a start/end date; the rental amount is calculated automatically from the number of days × the bus's daily price
- Basic business rule validation (e.g. purchase price capped for buses older than 5 years)

## Tech Stack
- C# / .NET Framework 4.8 (WinForms)
- ADO.NET (`System.Data.SqlClient`) for data access
- Microsoft SQL Server / SQL Server Express

## Architecture
The solution follows a layered architecture:

| Layer | Folder | Responsibility |
|---|---|---|
| Business objects | `metiers/` | `Bus`, `Location` domain classes |
| Data access | `DAO/` | Raw SQL against SQL Server |
| Controllers | `controller/` | Bridges the UI to the DAO layer |
| UI | `Tp2Bus/` | WinForms screens (`GererBus`, `GererLocation`) |

## Getting Started

### Prerequisites
- Visual Studio 2019+ with the ".NET desktop development" workload
- SQL Server or SQL Server Express

### Setup
1. Clone the repository.
2. Create a SQL Server database (e.g. `BDAgence`) with tables matching the `Bus` and `Location` classes.
3. Update the connection string in [`metiers/Connexion.cs`](metiers/Connexion.cs) to point to **your own** SQL Server instance:
   ```csharp
   static string url = @"Server=YOUR_SERVER\SQLEXPRESS;Database=BDAgence;Trusted_Connection=True";
   ```
4. Open `Tp2Bus.sln` in Visual Studio, restore/build the solution, and run.

## Known Issues / Roadmap
- [ ] Connection string is hardcoded to a specific machine name — move it to `App.config` and read it via `ConfigurationManager` (see "What to fix" notes)
- [ ] No input validation feedback on malformed numeric fields (capacity, prices)
- [ ] No automated tests
- [ ] No screenshots yet — add a few to this README once the UI is finalized

## License
Add a license of your choice (e.g. MIT) if you intend this to be public and reusable.
