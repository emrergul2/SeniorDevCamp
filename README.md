# Project Notes

## Add Migrations

> dotnet ef migrations add "InitialCreate" --project src/demoProjects/rentACar/Persistence/ --startup-project src/demoProjects/rentACar/WebAPI

## Update Database

> dotnet ef database update --project src/demoProjects/rentACar/Persistence/ --startup-project src/demoProjects/rentACar/WebAPI

## GetListByDynamic Model

```json

{
  "sort": [
    {
      "field": "name",
      "dir": "asc"
    }
  ],
  "filter": {
    "field": "name",
    "operator": "eq",
    "value": "Series 4",
    "logic": "or",
    "filters": [
      {
        "field": "dailyPrice",
        "operator": "gte",
        "value": "1000"
      }
    ]
  }
}

```
