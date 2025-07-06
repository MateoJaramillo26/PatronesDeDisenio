# 🚗 Patrones de Diseño en Ejercicio de Vehiculos

Este proyecto implementa una aplicación web utilizando **patrones de diseño orientados a objetos**, en el contexto de un sistema para la gestión de vehículos. Está pensado como un ejemplo práctico, similar a los que se usan en pruebas técnicas para desarrolladores web.

## 🧩 Patrones de diseño aplicados

### 1. **Singleton**
Utilizado para crear una única instancia de `MemoryCollection`, que funciona como un almacenamiento en memoria simulado para los objetos `Vehicle`.

- ✅ Útil en desarrollo sin base de datos.
- ✅ Permite pruebas funcionales sin persistencia externa.
- ✅ Reutilizable en todo el sistema sin múltiples instancias.

> 📁 Clase relevante: `MemoryCollection.cs`

---

### 2. **Builder**
Implementado a través de `CarModelBuilder`, permite construir objetos `Vehicle` complejos de forma clara, flexible y mantenible.

- ✅ Evita constructores largos.
- ✅ Facilita valores por defecto y encadenamiento de propiedades.
- ✅ Ideal para escenarios donde el modelo crecerá con el tiempo.

> 📁 Clase relevante: `CarModelBuilder.cs`

---

### 3. **Factory Method**
Permite la creación de diferentes modelos de vehículos (Mustang, Escape, Explorer) mediante fábricas especializadas.

- ✅ Facilita la extensión de nuevos modelos.
- ✅ Desacopla la lógica de construcción del controlador.
- ✅ Integra el patrón Builder para crear vehículos completos.

> 📁 Clases relevantes:
- `CarFactory.cs` (abstracta)
- `FordMustangFactory.cs`
- `FordEscapeFactory.cs`
- `FordExplorerFactory.cs`

---

## 💻 Tecnologías

- `ASP.NET Core MVC`
- `C#`
- `Razor Pages`
- Patrón de arquitectura MVC
- Inyección de dependencias (Dependency Injection)

---

## 🚀 Cómo ejecutar el proyecto

1. Clona este repositorio:
   ```bash
   git clone https://github.com/tu-usuario/design-patterns-vehicles.git
