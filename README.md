# WhyShop - Sistema de E-commerce

## Objetivo del Sistema
Desarrollar una plataforma de comercio electrónico eficiente y escalable que permita a los usuarios explorar productos, gestionar su carrito de compras y procesar pagos de forma segura.

## Problema que Resuelve
La falta de un sistema centralizado para gestionar el catálogo de productos y el inventario en tiempo real, lo que causaba desorganización y pérdida de ventas.

## Funcionalidades Principales
1. Registro y autenticación de usuarios.
2. Exploración y filtrado del catálogo de productos.
3. Gestión del carrito de compras (agregar productos, calcular subtotales).
4. Procesamiento de transacciones y pagos.
5. Actualización automática del inventario.

## Arquitectura Seleccionada
El sistema utiliza el patrón **MVC (Modelo-Vista-Controlador)** para garantizar la separación de responsabilidades y la escalabilidad.

## Organización Frontend y Backend
* **Frontend (Vista):** Es responsable de la interfaz gráfica (UI) y la experiencia del usuario. Captura las interacciones del cliente (clics, formularios) y muestra los datos del catálogo.
* **Backend (Controlador y Modelo):** El Controlador recibe las peticiones del Frontend, procesa la lógica y se comunica con el Modelo. El Modelo gestiona las reglas de negocio y se conecta directamente con la Base de Datos.
* **Comunicación:** Ambas partes se comunican a través de peticiones HTTP, donde el Frontend solicita datos y el Backend responde con la información procesada.

## Herramientas Utilizadas
* **Visual Paradigm Online:** Para el modelado arquitectónico y diagramas UML (Clases, Secuencia, Actividades, Casos de Uso).
* **GitHub & GitHub Projects:** Para el control de versiones, seguimiento de incidencias (Issues) y gestión ágil del proyecto mediante tableros Kanban.

## Estado Actual del Proyecto
Fase de diseño arquitectónico y modelado técnico finalizada. Repositorio inicial configurado y documentado para iniciar la fase de codificación.
