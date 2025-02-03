# 📌 Aplicación de Gestión de Entradas al Parque de Carbones

## 📖 Descripción

Esta aplicación permite gestionar la entrada de camiones al parque de carbones, registrar sus datos y analizar la información de ingreso mediante reportes y gráficos.

## 🚀 Funcionalidades Principales

- ✅ Registro de Entradas: Permite registrar camiones con su matrícula, peso y datos del camionero.

- 🔍 Filtrado por Fecha y Camión: Posibilita la consulta de entradas de un camión específico en un rango de fechas.

- 📊 Gráficos Comparativos: Genera reportes gráficos que muestran la cantidad de carbón ingresado por día y hora.

- 🚛 Gestión de Permisos: Determina si un camión tiene permiso para ingresar al parque.

- 📂 Exportación de Datos: Permite exportar los datos de entrada a un archivo CSV.

## 🏛️ Estructura de la Base de Datos

La aplicación usa una base de datos SQL Server con las siguientes tablas principales:

- 📌 Camiones: Registra los camiones con su matrícula, empresa y peso máximo permitido.

- 📌 Camioneros: Almacena la información de los conductores.

- 📌 Entradas: Guarda los registros de ingreso de cada camión con su peso y fecha/hora.

## 🛠️ Uso de la Aplicación

- Registro de Entradas: Seleccionar un camión y un camionero, ingresar el peso y guardar la entrada.

- Consulta por Fecha: Seleccionar una fecha y filtrar las entradas registradas.

- Visualización de Gráficos: Consultar el gráfico de toneladas ingresadas por hora y día.

- Exportación: Guardar los datos en formato CSV para análisis externo.

## 💻 Requisitos del Sistema

- 🏗️ .NET Framework o .NET Core

- 🗄️ SQL Server (Local o Remoto)

- 🎯 Visual Studio (para desarrollo y mantenimiento)
