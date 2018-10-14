## APLICACI�N PARA LA GESTI�N DE INFRACCIONES

#### Aplicaci�n basada en el proyecto DDD NLayared .NET 4.0 Architecture de C�sar de la Torre ####
https://blogs.msdn.microsoft.com/cesardelatorre/2010/03/25/our-brand-new-ddd-n-layered-net-4-0-architecture-guide-book-and-sample-app-in-codeplex/

### Instalaci�n de la base de datos

1. En Visual Studio, Abrir el Package Manager Console
2. Establecer Default project = "Infrastructure.Data.MainBoundedContext"
3. Ejecutar los siguientes comandos en el Package Manager Console:
	* Add-Migrations Initial
	* Update-Database


### Descripci�n de la soluci�n

La aplicaci�n se divide en dos partes. 
1. **CLIENTE**: Comprende los proyectos que se encuentran dentro de la carpeta **"Presentation"**. Son aplicaciones Windows que se ejecutan en la m�quina del usuario. Se conectan con el servidor realizando llamadas REST al proyecto DistributedServices.MainBoundedContext.Api
    * **Presentation.Windows.Seedwork:** Librer�as para el manejo de las llamadas REST al servidor.
    * **Presentation.Windows.UI:** Aplicaci�n principal.
    

1. **SERVIDOR**: Comprenden los dem�s proyectos. Se ejecutan el el **Servidor**.

	* **DistributedServices.MainBoundedContext.Api:** Servicios REST desarrollados con Web API 2
    * **Application.Seedwork:** Proyecto que contiene m�todos (proyecciones de entidades a dtos, validaciones, ...) que ser�n utilizados en la capa Application.MainBoundedContext
    * **Application.MainBoundedContext:** En este proeycto se reciben las solicitudes de la capa de servicios REST, se procesan las entidades, y se devuelven los resultados en formato DTOs. 
    * **Application.MainBoundedContext.DTO:** Proyecto donde se encuentran definidos todos las clases DTO. Tambi�n se definen como se van a mapear las Entidades del dominio en objetos DTO por medio de AutoMapper.
    * **Domain.Seedwork:** Proyecto donde se establecen las clases base y m�todos utilizados en las capas del dominio.
    * **Domain.MainBoundedContext:** Proyecto donde se definen las entidades, y los repositorios de cada entidad. En algunas clases tambi�n se utiliza el patr�n Factory
    * **Infrastructure.GlobalResources:** Proyecto donde se encuentrar los recursos de texto utilizados en los dem�s proyectos.
    * **Infrastructure.CrossCutting.Seedwork:** Definici�n de tipos (Caching, Loging, ...) que se utilizar�n en el proyecto Infrastructure.CrossCutting.NetFramework. 
    * **Infrastructure.CrossCutting.NetFramework:** Implementaci�n de las clases definidas en el proyecto anterior.
    * **Infrastructure.CrossCutting.MainBoundedContext.IoC:** Proyecto que implementa el patr�n ID (Inyecci�n de dependencias).
    * **Infrastructure.Data.Seedwork:** Definici�n de los tipos utilizados en el contexto, y la clase Repository, de la que heredar�n cada uno de los repositorios de las entidades del dominio. 
    * **Infrastructure.Data.MainBoundedContext:** Proyecto donde se encuentran:
        * El contexto principal (MainBCUnitOfWork)
        * Cada uno de los repositorios de cada entidad (DgtModule/Repositories/*Repository.cs)
        * Los registros iniciales de cada una de las entidades (DgtModule/InitialData/InitialData*.cs)
        * Los archivos de migraci�n utilizados por Entity Framework Code First
        * La definici�n de c�mo cada entidad se guarda en la Base de datos (DgtModule/UnitOfWork/Mapping/*EntityConfiguration.cs)