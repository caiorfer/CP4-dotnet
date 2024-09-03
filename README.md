# Conversor de Moedas WebAPI

![.NET Core](https://img.shields.io/badge/.NET%20Core-6.0-blue)
![C#](https://img.shields.io/badge/C%23-8.0-green)
![Azure DevOps](https://img.shields.io/badge/Azure%20DevOps-Pipelines-orange)

## Visão Geral

Esta é uma WebAPI desenvolvida em .NET Core que realiza a conversão da taxa de câmbio entre o dólar americano (USD) e o real brasileiro (BRL) utilizando a [Exchangerate API](https://www.exchangerate-api.com/). A API fornece uma maneira simples de consultar a taxa de câmbio atual entre essas moedas.

## Funcionalidades

- Consulta em tempo real da taxa de câmbio USD/BRL.
- Retorno em formato JSON com informações detalhadas.
- Documentação da API disponível via Swagger.

## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado em seu ambiente de desenvolvimento:

- [.NET Core SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)
- Conta no [Azure DevOps](https://dev.azure.com/)

## Uso
Endpoint de Conversão de Moeda
URL: GET /api/exchange-rate

Resposta de Sucesso:

json
Copiar código
{
    "CurrencyPair": "USD/BRL",
    "Rate": 5.25,
    "Date": "2024-09-01T12:34:56Z"
}
