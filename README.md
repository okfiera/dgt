## APLICACIÓN PARA LA GESTIÓN DE INFRACCIONES

#### Aplicación basada en el proyecto DDD NLayared .NET 4.0 Architecture de César de la Torre ####
https://blogs.msdn.microsoft.com/cesardelatorre/2010/03/25/our-brand-new-ddd-n-layered-net-4-0-architecture-guide-book-and-sample-app-in-codeplex/

### Instalación de la base de datos

1. En Visual Studio, Abrir el Package Manager Console
2. Establecer Default project = "Infrastructure.Data.MainBoundedContext"
3. Ejecutar los siguientes comandos en el Package Manager Console:
	* Add-Migrations Initial
	* Update-Database


### Descripción de la solución

La aplicación se divide en dos partes. 
1. **CLIENTE**: Comprende los proyectos que se encuentran dentro de la carpeta **"Presentation"**. Son aplicaciones Windows que se ejecutan en la máquina del usuario. Se conectan con el servidor realizando llamadas REST al proyecto DistributedServices.MainBoundedContext.Api
    * **Presentation.Windows.Seedwork:** Librerías para el manejo de las llamadas REST al servidor.
    * **Presentation.Windows.UI:** Aplicación principal.
    

1. **SERVIDOR**: Comprenden los demás proyectos. Se ejecutan el el **Servidor**.

	* **DistributedServices.MainBoundedContext.Api:** Servicios REST desarrollados con Web API 2
    * **Application.Seedwork:** Proyecto que contiene métodos (proyecciones de entidades a dtos, validaciones, ...) que serán utilizados en la capa Application.MainBoundedContext
    * **Application.MainBoundedContext:** En este proeycto se reciben las solicitudes de la capa de servicios REST, se procesan las entidades, y se devuelven los resultados en formato DTOs. 
    * **Application.MainBoundedContext.DTO:** Proyecto donde se encuentran definidos todos las clases DTO. También se definen como se van a mapear las Entidades del dominio en objetos DTO por medio de AutoMapper.
    * **Domain.Seedwork:** Proyecto donde se establecen las clases base y métodos utilizados en las capas del dominio.
    * **Domain.MainBoundedContext:** Proyecto donde se definen las entidades, y los repositorios de cada entidad. En algunas clases también se utiliza el patrón Factory
    * **Infrastructure.GlobalResources:** Proyecto donde se encuentrar los recursos de texto utilizados en los demás proyectos.
    * **Infrastructure.CrossCutting.Seedwork:** Definición de tipos (Caching, Loging, ...) que se utilizarán en el proyecto Infrastructure.CrossCutting.NetFramework. 
    * **Infrastructure.CrossCutting.NetFramework:** Implementación de las clases definidas en el proyecto anterior.
    * **Infrastructure.CrossCutting.MainBoundedContext.IoC:** Proyecto que implementa el patrón ID (Inyección de dependencias).
    * **Infrastructure.Data.Seedwork:** Definición de los tipos utilizados en el contexto, y la clase Repository, de la que heredarán cada uno de los repositorios de las entidades del dominio. 
    * **Infrastructure.Data.MainBoundedContext:** Proyecto donde se encuentran:
        * El contexto principal (MainBCUnitOfWork)
        * Cada uno de los repositorios de cada entidad (DgtModule/Repositories/*Repository.cs)
        * Los registros iniciales de cada una de las entidades (DgtModule/InitialData/InitialData*.cs)
        * Los archivos de migración utilizados por Entity Framework Code First
        * La definición de cómo cada entidad se guarda en la Base de datos (DgtModule/UnitOfWork/Mapping/*EntityConfiguration.cs)