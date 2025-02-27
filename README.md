# Calculadora de Notas en C#

Este repositorio contiene un programa en **C#** que permite calcular la nota definitiva de un estudiante en un curso universitario. La nota final se obtiene en función de tres cortes evaluativos con diferentes ponderaciones.

## 📌 Características del Programa
- Implementación en **C#** utilizando **Programación Orientada a Objetos (POO)**.
- Validación de las notas ingresadas para que estén en el rango de **0 a 5**.
- Cálculo de la nota de cada corte y de la **nota final**.
- Manejador de **excepciones** para valores fuera del rango o formatos incorrectos.

## 📊 Distribución de la Calificación
El curso se divide en **tres cortes**, cada uno con las siguientes evaluaciones y ponderaciones:

### **Primer Corte (30%)**
- **Quiz 1** → 10%
- **Idea de proyecto grupal** → 5%
- **Parcial 1** → 15%

### **Segundo Corte (30%)**
- **Mesa de debate avanzada** → 5%
- **Ajuste y desarrollo avanzado del proyecto** → 20%
- **Simulación del pitch final** → 5%

### **Tercer Corte (40%)**
- **Quiz 2** → 10%
- **Pitch grupal final** → 20%
- **Autoevaluación** → 5%
- **Coevaluación** → 5%

## 🛠 Instalación y Uso
### **Requisitos**
- Tener **.NET SDK** instalado en el sistema.
- Un editor como **Visual Studio Code** o **Visual Studio**.

### **Ejecución del Programa**
1. **Clona este repositorio:**
   ```bash
   git clone https://github.com/tu-usuario/calculadora-notas.git
   cd calculadora-notas
   ```
2. **Compila el código:**
   ```bash
   csc Nota.cs
   ```
3. **Ejecuta el programa:**
   ```bash
   ./Nota.exe
   ```
4. **Ingresa las notas cuando se soliciten.**

## 🔍 Ejemplo de Uso
```
Ingrese las notas (0 - 5.0):
Quiz 1: 4.5
Idea proyecto grupal: 4.0
Parcial 1: 3.8
Mesa de debate Avanzada: 4.2
Ajuste y desarrollo avanzado del proyecto: 3.9
Simulación del pitch final: 4.8
Quiz 2: 4.0
Pitch grupal final: 4.5
Autoevaluación: 5.0
Coevaluación: 4.7

Nota del Primer Corte: 1.54
Nota del Segundo Corte: 1.76
Nota del Tercer Corte: 3.10
Nota Final del Curso: 6.40
```

## ⚠ Manejo de Errores
Si el usuario ingresa un valor fuera del rango permitido (0-5), el programa lanzará una excepción:
```
Quiz 1: 5.5
Error: La nota debe estar entre 0 y 5.
```
Si el usuario ingresa un valor no numérico:
```
Quiz 1: abc
Error: Ingrese un número válido.
```

## 📜 Licencia
Este proyecto se distribuye bajo la **MIT License**. ¡Siéntete libre de usarlo y mejorarlo! 🚀

