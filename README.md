# Number To Words Web Application

## Overview

This project is a full-stack web application that converts numeric input into words in English currency format (Dollars and Cents).

### Example

Input: `123.45`  
Output:  
`ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS`

The solution is implemented using:
- ASP.NET Core Web API (Backend)
- React.js (Frontend)

Note: No external libraries or NuGet packages were used for number-to-words conversion, as per assignment requirements.

---
## UI Screenshots
### Main UI
![Main UI](Screenshot 2026-05-14 102521.png)

### Result UI
![Result UI](Screenshot 2026-05-14 102731.png)

##  Architecture

### Frontend (React)
- Functional component using `useState`
- Input field for number entry
- Calls backend API using `fetch`
- Displays converted result

### Backend (ASP.NET Core)
- REST API endpoint
- Service-based architecture
- Custom recursive algorithm for conversion

---

## Features

- Converts numbers into words
- Supports:
  - Units, Tens, Hundreds
  - Thousands and Millions
  - Decimal values (Cents)
- Currency format output (DOLLARS & CENTS)
- Clean separation of UI and business logic

---

## API Endpoint

GET /api/numbertowords/Convert?number={value}

### Example

http://localhost:5095/api/NumberToWords/Convert?number=201.6

### Response
TWO HUNDRED AND ONE DOLLARS AND SIXTY CENTS

##  Frontend Flow

1. User enters a number
2. Clicks Convert button
3. API is called
4. Result is displayed

---

## Approach & Design

### Approach Used
A recursive algorithm is used to break the number into:
- Millions
- Thousands
- Hundreds
- Tens and Units

Each part is converted into words and combined.

### Why this approach?
- Simple and maintainable
- Scalable for large numbers
- Fully custom implementation
- Meets assignment constraint (no external libraries)

### Alternatives Not Used
- NuGet libraries (not allowed)
- Hardcoded mappings (not scalable)
- Regex-based logic (complex)

##Test Plan

### Test Scenarios

| Input | Expected Output |
|------|----------------|
| 123.45 | ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS |
| 1000 | ONE THOUSAND DOLLARS AND ZERO CENTS |
| 0 | ZERO DOLLARS AND ZERO CENTS |


---

##  Project Structure

NumberToWords/
│
├── NumberToWordsAPI
│   ├── Controllers
│   ├── Services
│   └── Program.cs
│
├── frontend
│   ├── App.js
│   └── index.js
│
└── README.md

##  Notes

- Fully custom algorithm implementation
- No external libraries used
- Designed as per assignment requirements
- Focus on clean code and maintainability

