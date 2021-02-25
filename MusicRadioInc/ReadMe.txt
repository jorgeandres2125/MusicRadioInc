Para acceder como usuario cliente use
cliente.001@gmail.com
pass: cliente123

Para acceder como Director de inventario
admin.radio@gmail.com

El proyecto se divide asi:
MusicRadioStore.Core => Clases de dominio e interfaces de servicio y repositorio para el comportamiento
MusicRadioStore.DataAccess.SQL => Clases de implementación de persistencia de repositorio aqui se cambia la conexion a la base de datos
MusicRadioStore.Service => Capa logica en la que se implementa el acceso a datos y la regla del negocio
MusicRadioStore.WebUI => Aplicación MVC en la que se usa la aplicacion web, framework identity unity para la inyección de dependencias
MusicRadioStore.WebUI.Tests => capa donde se implementan pruebas unitarias