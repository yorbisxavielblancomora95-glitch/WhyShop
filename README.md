# WhyShop - Plataforma de Comercio Electrónico

WhyShop es un proyecto de tienda en línea pensado para pequeños y medianos negocios que quieren dar el salto a las ventas digitales sin perder el control de su inventario físico.

### ¿Cuál es el objetivo del sistema?
Ofrecer una plataforma web rápida y fácil de usar donde los clientes puedan ver el catálogo de artículos, armar su carrito de compras y pagar con tarjeta de forma segura. Al mismo tiempo, busca facilitarle la vida al administrador de la tienda descontando el stock automáticamente con cada compra.

### Problema que buscamos resolver
Muchos comercios locales todavía toman pedidos de forma manual (por redes sociales o WhatsApp), lo que casi siempre termina en confusiones, ventas de productos que ya se agotaron y desorden en las cuentas. WhyShop centraliza todo ese proceso para que el inventario esté siempre al día sin tener que cruzar datos a mano.

### Funcionalidades principales
* Registro e inicio de sesión de usuarios (autenticación).
* Catálogo interactivo con filtros de búsqueda.
* Carrito de compras que calcula el subtotal en tiempo real.
* Procesamiento de pagos con validación de estado de la transacción.
* Actualización automática del stock en la base de datos tras cada compra exitosa.

### Arquitectura elegida
Para este sistema decidimos utilizar el patrón **Modelo-Vista-Controlador (MVC)**. Lo elegimos porque nos permite dividir el proyecto en capas claras, evitando mezclar el diseño de las pantallas con las reglas de cobro o las consultas a la base de datos.

### Organización entre Frontend y Backend
* **Frontend (Vista):** Es toda la parte visual con la que interactúa el comprador (el catálogo, los botones del carrito, el formulario de login). Su única responsabilidad es mostrar los datos de forma amigable y capturar lo que el usuario quiere hacer.
* **Backend (Controlador y Modelo):** Aquí vive la lógica pesada del sistema. El **Controlador** recibe las peticiones que vienen desde la pantalla y coordina qué hacer, mientras que el **Modelo** aplica las reglas del negocio (como verificar si hay stock suficiente o validar credenciales) y se encarga de hablar directamente con la Base de Datos.
* **¿Cómo se comunican?:** Ambas partes se conectan mediante peticiones HTTP enviando y recibiendo datos en formato JSON. De esta forma, si mañana queremos cambiar el diseño de la página web, podemos hacerlo sin temor a dañar la programación del backend.

### Herramientas que hemos utilizado
* **Diseño de interfaz:** Figma (para los prototipos visuales).
* **Modelado y Arquitectura:** Visual Paradigm Online (para todos los diagramas UML y la estructura de bloques).
* **Organización y Control de Versiones:** Git, GitHub Repositories, GitHub Issues y GitHub Projects (tablero Kanban).
* **Entorno pensado para la programación:** HTML, CSS y JavaScript para el frontend; C# en el backend conectado a Microsoft SQL Server.

### Estado actual del proyecto
Actualmente hemos finalizado al 100% la etapa de análisis, levantamiento de requerimientos, diseño arquitectónico y modelado UML. El repositorio y el entorno de gestión ya están estructurados para pasar directamente a la fase de programación y creación de la base de datos.
