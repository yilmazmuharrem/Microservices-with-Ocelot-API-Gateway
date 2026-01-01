<p align="center">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-7-512BD4?logo=dotnet&logoColor=white" />
  <img alt="ASP.NET Core" src="https://img.shields.io/badge/ASP.NET%20Core-Web%20API-512BD4?logo=dotnet&logoColor=white" />
  <img alt="Docker" src="https://img.shields.io/badge/Docker-Compose-2496ED?logo=docker&logoColor=white" />
  <img alt="Ocelot" src="https://img.shields.io/badge/Ocelot-API%20Gateway-6E40C9?logo=nuget&logoColor=white" />
</p>


# Microservices with Ocelot API Gateway

A sample **microservices architecture** built with **.NET 7**, using **Ocelot API Gateway** for request routing and **Docker Compose** for container orchestration.

The project demonstrates service-to-gateway communication, independent service deployment, and centralized API access.

---

## 🧱 Architecture Overview

- Each microservice runs independently in its own container
- **Ocelot API Gateway** acts as a single entry point
- Services communicate over HTTP
- Docker Compose manages multi-container setup

---

## 🧑‍💻 Technologies

- **.NET 7**
- **ASP.NET Core Web API**
- **Ocelot API Gateway**
- **Docker**
- **Docker Compose**
- **Microservices Architecture**

---

## 🔌 Services

| Service        | Description              | Port |
|---------------|--------------------------|------|
| Company API   | Company management service | 9000 |
| Sales API     | Sales operations service  | 9001 |
| API Gateway   | Ocelot Gateway            | 9002 |

---

## ⚙️ How to Run (Docker)

### Requirements
- Docker Desktop

### Steps

```bash
git clone https://github.com/username/microservices.git
cd microservices
docker compose up --build
