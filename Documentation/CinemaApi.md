# Seznam jednotlivých API enpointů

# Auth

Slouží pro přihlašování a registraci uživatelských účtů. Úspěšná registrace nebo úspěšně přihlášení vygeneruje token pro přistupování k vybraným API endpointům.

| Request Url      | Typ | Popis |
| ----------- | ----------- | ----------- |
| https://localhost:3333/auth/login    | **POST** |  Provede přihlášení uživatele s pomocí zadaných údajů.  |
| https://localhost:3333/auth/register  | **POST** | Provede registraci uživatele s pomocí zadaných údajů.        |
<br />
## Příklad přihlášení uživatele

Pro přihlášení uživatele zavoláme na endpoint https://localhost:3333/auth/login s následujicími daty.

```
{
    "Username": "Franta",
    "Heslo123": "heslo123"
}
```

Existuje-li uživatel v databázi, API provede kontrolu hesla. V případě, že hesla sedí, uživateli se vygeneruje authentication token, se kterým bude moci přistupovat k vybraným endpointům. Neshoda hesel token nevytvoří (uživatel nebude přihlášen).

## Vrácená data při úspěšném přihlášení

```
{
    "message": "Logged in successfully",
    "token": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVG9iacOhxaEiLCJleHAiOjE2ODA0MzQxNzF9.CzcMiRht4hjf7ennpil7jJV4GrOa-ERpsOkS5_xusiFWlTDHgdkpKm16lSvx4Oc-GgGpLvMnDRbBhhaRgkh__Q"
}
```
<br /><br />
## Příklad registrace uživatele

Pro přihlášení uživatele zavoláme na endpoint https://localhost:3333/auth/register s následujicími daty.

```
{
    "Username": "Franta",
    "Heslo123": "heslo123"
}
```

Neexistuje-li uživatel v databázi, API provede jeho registraci.

## Vrácená data při úspěšné registraci

```
{
    "message": "User successfully registered",
    "token": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiRnJhbnRhIiwiZXhwIjoxNjgwNDM0MzU1fQ.08GZ4tLvaL9dci3LL5VadwStZuoHbIXYRooDxxmBjV8ZUQrGmwykXASyHWDpuOXGVUPSJbrP2BDGzbZsrfR_Yw"
}
```
<br /><br /><br />

# Movies

Slouží pro výběr dat o filmech a jejich promítání.

## Endpointy

| Request Url      | Typ | Popis |
| ----------- | ----------- | ----------- |
| https://localhost:3333/api/movies    | **GET** |  Vybere všechny filmy z databáze a vrátí jejich data.  |
| https://localhost:3333/api/movies/{id}  | **GET** | Vybere jeden film pomocí ID parametru a vrátí data o něm.        |

<br />

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
<br />

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



