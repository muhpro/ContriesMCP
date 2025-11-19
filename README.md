# Countries MCP Server

A Model Context Protocol (MCP) server that enables AI agents, including GitHub Copilot in VS Code, to query country data dynamically.

## Overview

This project demonstrates the power of MCP by creating a seamless integration between AI agents and external data sources. The server exposes country information through standardized tools that LLMs can invoke.

## External Context

**Data Source:** [REST Countries API](https://restcountries.com/)

This MCP server integrates with the **REST Countries API** as an external context provider, enabling AI agents to:
- Query comprehensive country data
- Retrieve information about all countries globally
- Look up specific countries by name
- Access structured country metadata including capitals, regions, and population data

## Features

- **Get All Countries**: Retrieve a complete list of all countries with their flags
- **Get Country by Name**: Look up specific country information by name

## Tools Available

### GetAllCountriesAsync
Returns a list of all countries with their names and flag images.

### GetCountryByNameAsync
Retrieves detailed information for a specific country, including:
- Country name
- Capital(s)
- Region
- Population
- Flag(s) (PNG and SVG)

## Technology Stack

- **.NET 10.0**
- **Model Context Protocol (MCP)**
- **REST Countries API** (External Data Source)
- **C#**

## Getting Started

The MCP server automatically integrates with GitHub Copilot and other LLM clients that support the Model Context Protocol, providing them with instant access to country data through the REST Countries API.

---

*Built with the Model Context Protocol - Enabling the next generation of AI-powered applications.*
