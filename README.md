# Tickets (HNSC)

Primer prototipo (noviembre de 2018) de un sistema de tickets de turno para las clínicas del Hospital Nuestra Señora del Carmen (Cobán, Alta Verapaz), hecho en VB.NET con WPF.

## Contexto

- Año: 2018.
- Proyecto de estudiante y punto de partida de [Hospital-Repair](https://github.com/thealejandro/Hospital-Repair) (2018) y [HospitalNSC](https://github.com/thealejandro/HospitalNSC) (2019).
- Es una prueba de concepto de interfaz: no tiene lógica de negocio real.
- Proyecto histórico, sin mantenimiento. Lo conservo como registro de mi trayectoria; la versión actual de esta idea son xaCare y xaSeguros, en https://xacode.dev.

## Funcionalidades observadas en el código

- Ventana de inicio de sesión con tres usuarios fijos en el código, cada uno abre una ventana de prueba distinta.
- `Base`: maqueta de ticket con código de paciente y clínica del doctor.
- `Mod2`: maqueta para el doctor con botones "Siguiente" y "Marcar como ocupado".
- `Mod3`: maqueta de ajustes.
- Prueba de conexión a MySQL (base `hnsc`) al cargar la ventana principal.

## Tecnologías

- VB.NET, WPF, .NET Framework 4.6.1.
- MaterialDesignThemes 2.5, MySql.Data 8.0.13, CefSharp (referenciado, sin uso).

## Cómo abrirlo

Abrir `HNSC/HNSC.sln` en Visual Studio 2017 o superior y restaurar los paquetes NuGet.

El archivo `_config.yml` es un remanente de GitHub Pages y no forma parte del proyecto.

## Estado

Proyecto histórico, sin mantenimiento.

## Licencia

GPL-2.0 (ver `LICENSE`).
