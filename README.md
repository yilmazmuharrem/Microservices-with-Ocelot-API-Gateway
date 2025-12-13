# Microservices with Ocelot API Gateway

This project demonstrates a microservices architecture using:
- .NET 7
- Ocelot API Gateway
- Docker & docker-compose

## Services
- Company API (port 9000)
- Sales API (port 9001)
- API Gateway (port 9002)

## How to Run (Docker)
Requirements:
- Docker Desktop

Steps:
```bash
git clone https://github.com/username/microservices.git
cd microservices
docker compose up --build
