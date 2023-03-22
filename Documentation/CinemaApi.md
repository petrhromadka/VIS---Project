# Seznam jednotlivých API enpointů

# Movies

Slouží pro výběr dat o filmech a jejich promítání.

## Endpointy

| Request Url      | Typ | Popis |
| ----------- | ----------- | ----------- |
| https://localhost:3333/api/movies    | **GET** |  Vybere všechny filmy z databáze a vrátí jejich data.  |
| https://localhost:3333/api/movies/{id}  | **GET** | Vybere jeden film pomocí ID parametru a vrátí data o něm.        |

## Příklad vrácených dat

Vrácená data po zavolání na endpoint https://localhost:3333/api/movies/1.

```
{
"id": 1,
"title": "ANT-MAN A WASP: QUANTUMANIA",
"genre": "Akční",
"duration": 125,
"director": "Peyton Reed",
"description": null,
"rating": 12,
"events": [
        {
        "id": 1,
        "dateTime": "2023-03-13T14:20:00",
        "price": 180
        },
        {
        "id": 2,
        "dateTime": "2023-03-13T17:10:00",
        "price": 180
        },
        {
        "id": 3,
        "dateTime": "2023-03-13T20:30:00",
        "price": 180
        },
        {
        "id": 4,
        "dateTime": "2023-03-14T14:20:00",
        "price": 180
        },
        {
        "id": 5,
        "dateTime": "2023-03-14T17:10:00",
        "price": 180
        },
        {
        "id": 6,
        "dateTime": "2023-03-14T20:30:00",
        "price": 180
        },
        {
        "id": 7,
        "dateTime": "2023-03-15T14:20:00",
        "price": 180
        },
        {
        "id": 8,
        "dateTime": "2023-03-15T17:10:00",
        "price": 180
        },
        {
        "id": 9,
        "dateTime": "2023-03-15T21:40:00",
        "price": 180
        }
    ]
}
```

## Popis vrácených dat

| Název vlastnosti | Datový typ | Popis |
| ----------- | ----------- | ----------- |
| **id**    | int |  Identifikátor filmu  |
| **title**    | string |  Název filmu  |
| **genre**    | string |  Žánr filmu  |
| **duration**    | int |  Délka filmu  |
| **director**    | string |  Režisér filmu  |
| **description**    | string |  Popisek filmu  |
| **rating**    | int |  Věková přístupnost  |
| **events**    | int |  Seznám promítání filmu  |
| **events[0].id**    | int |  Identifikátor promítání |
| **events[0].dateTime**    | DateTime |  Čas promítání  |
| **events[0].price**    | int |  Cena promítání  |



