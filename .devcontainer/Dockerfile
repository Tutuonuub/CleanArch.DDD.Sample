FROM mcr.microsoft.com/dotnet/sdk:8.0

# Instala o EF Core CLI e dependências
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

WORKDIR /workspace
