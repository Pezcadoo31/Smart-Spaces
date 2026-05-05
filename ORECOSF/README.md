# Sistema de control multi-zona para edificio de oficinas — Crestron MC3

> **Proyecto de aprendizaje y portafolio** enfocado en arquitecturas Crestron multi-zona escalables. Desarrollado con un procesador **Crestron MC3** y tres touchpanels **TSR-310**, controlando audio, video, iluminación y climatización de un edificio con tres oficinas independientes.

> ⚠️ **Nota sobre datos del proyecto:** Las direcciones IP, credenciales y nombres de zonas que aparecen aquí son **valores ficticios** seleccionados dentro de un mismo segmento de red (`192.168.0.x`) para mantener una lógica realista de instalación. Los nombres de las carpetas (`ORECOSF`, `ORECOControls`, etc.) son nombres internos heredados del proyecto y no corresponden a ningún cliente real.

---

## Índice

1. [Objetivo del proyecto](#1-objetivo-del-proyecto)
2. [Arquitectura general](#2-arquitectura-general)
3. [Hardware utilizado](#3-hardware-utilizado)
4. [Drivers y módulos de terceros](#4-drivers-y-módulos-de-terceros)
5. [Estructura del repositorio](#5-estructura-del-repositorio)
6. [Convenciones del proyecto](#6-convenciones-del-proyecto)
7. [Estado actual y trabajo pendiente](#7-estado-actual-y-trabajo-pendiente)
8. [Backups previos a Git](#8-backups-previos-a-git)
9. [Cómo reutilizar partes de este proyecto](#9-cómo-reutilizar-partes-de-este-proyecto)

---

## 1. Objetivo del proyecto

Diseñar un sistema Crestron donde **cada oficina** (Z1, Z2, Z3) tenga su propio touchpanel **TSR-310** capaz de controlar:

- **Audio** — streaming BluOS, aislado por oficina
- **Video** — pantalla profesional Samsung, aislada por oficina
- **Iluminación** — Lutron RadioRA 3, aislada por oficina (cada panel solo controla las luces de su zona)
- **HVAC** — Aidoo Pro de Airzone, compartido entre las tres oficinas
- **Persianas** — Somfy, compartidas (pendiente de integración)

Los tres TSR-310 corren la **misma interfaz visual** (un solo `.vtp` compilado a tres `.vtz` idénticos). La diferenciación entre oficinas se hace en **SIMPL Windows**: cada IP-ID dispara signals propios con prefijo de zona (`Z1_*`, `Z2_*`, `Z3_*`).

---

## 2. Arquitectura general

```
                          ┌─────────────────────┐
                          │   Crestron MC3      │
                          │   192.168.0.128     │
                          └──────────┬──────────┘
                                     │
              ┌──────────────────────┼──────────────────────┐
              │                      │                      │
       ┌──────▼─────┐         ┌──────▼─────┐         ┌──────▼─────┐
       │  TSR-310   │         │  TSR-310   │         │  TSR-310   │
       │  IP-ID-03  │         │  IP-ID-04  │         │  IP-ID-05  │
       │ (Oficina 1)│         │ (Oficina 2)│         │ (Oficina 3)│
       └──────┬─────┘         └──────┬─────┘         └──────┬─────┘
              │                      │                      │
              ├── Z1_Audio_*  ───┐   ├── Z2_Audio_*  ───┐   ├── Z3_Audio_*  ───┐
              ├── Z1_TV_*    ───┤   ├── Z2_TV_*    ───┤   ├── Z3_TV_*    ───┤
              ├── Z1_Lut_*   ───┤   ├── Z2_Lut_*   ───┤   ├── Z3_Lut_*   ───┤
              │                 │   │                 │   │                 │
              └─────────────────┴───┴─── HVAC, Persianas ──── (compartidos) ─┘
```

### Subsistemas aislados por zona (uno por oficina)

| Subsistema | Z1 | Z2 | Z3 |
|---|---|---|---|
| Audio (BCS300 BluOS) | IP `.194`, puerto CRPC `48005` | IP `.212`, puerto `48006` | IP `.213`, puerto `48007` |
| Video (Samsung Pro) | LH98BEDH 98", puerto MDC `1515` | LH65BEFH 65" | LH65BEFH 65" |
| Iluminación (Lutron) | `Z1_Lut_All_On/Off` | `Z2_Lut_All_On/Off` | `Z3_Lut_All_On/Off` |

### Subsistemas compartidos

- **HVAC** — 1 Aidoo Pro en `192.168.0.233`, controlado por los tres paneles. Estado y temperatura visibles en los tres TSR.
- **Lutron RadioRA 3** — 1 procesador único, pero las luces se agrupan internamente en zonas separadas en su programación (RA3 Designer). Desde Crestron, cada TSR solo dispara los `Z*_Lut_All_*` correspondientes a su oficina, así nunca enciende las luces de las otras.

---

## 3. Hardware utilizado

### Crestron

| Componente | Modelo | Función |
|---|---|---|
| Procesador | Crestron MC3 (C2I-MC3) | Cerebro del sistema, ejecuta el programa SIMPL |
| Touchpanel | TSR-310 (×3) | Control de usuario en cada oficina |

### Audio / Video

| Componente | Modelo | Cantidad | Notas |
|---|---|---|---|
| Streamer de audio | Bluesound BCS300 (BluOS) | 3 | Uno por oficina, con sus bocinas asociadas |
| Pantalla profesional 98" | Samsung LH98BEDH | 1 | Para Z1 (oficina principal) |
| Pantalla profesional 65" | Samsung LH65BEFH | 2 | Para Z2 y Z3 |

### Iluminación, climatización y persianas

| Componente | Modelo | Notas |
|---|---|---|
| HVAC | Aidoo Pro (Airzone) | Control sobre HTTP REST. Se conecta al equipo de aire acondicionado físico instalado en el edificio. |
| Iluminación | Lutron RadioRA 3 | Con zonas pre-configuradas en RA3 Designer |
| Persianas | Somfy | **Pendiente de integración** |

---

## 4. Drivers y módulos de terceros

Todos los drivers usados en este proyecto son **gratuitos** y se descargan del [Crestron Application Market](https://applicationmarket.crestron.com/). Se listan los enlaces directos para que cualquier integrador pueda obtener las mismas versiones.

### HVAC — Airzone (incluye módulos utilitarios de Ultamation)

🔗 **[AirZone v1.0](https://applicationmarket.crestron.com/airzone-v1-0/)**

Este paquete trae varios módulos juntos. De este paquete se utilizaron en el proyecto:

- `Equipment Control Destination Huge (Ultamation) v4.0.umc` — destino multi-pin para el ruteo de botones del TSR-310 hacia comandos IR del Samsung
- `Ultamation Analog to Serial String v2.usp/.ush` — utilitario para convertir un valor analógico a string serial
- (Inicialmente también se exploró el módulo nativo del paquete para HVAC, pero terminó reemplazándose por un parser custom — ver más abajo)

### Audio — Bluesound BluOS

🔗 **[BluOS Unified Driver v1.6.0](https://applicationmarket.crestron.com/bluos-unified-driver-v1-6-0/)**

Este paquete incluye varios módulos relacionados con BluOS y reproducción multimedia. Los utilizados son:

- `BluOS Unified Driver Wrapper v1.6.0.umc` — wrapper que registra la conexión al BCS300 vía protocolo CRPC
- `BluOS Unified Driver v1.6.0.usp/.ush` — driver SIMPL+ subyacente
- `Media Server Object Router v4.0` — viene incluido en este mismo paquete. Funciona como puente entre el Smart Object del touchpanel (que muestra portada, título y artista) y el wrapper

### Iluminación — Lutron RadioRA 3

🔗 **[Lutron RadioRA 3 Control v1.1.1](https://applicationmarket.crestron.com/lutron-radiora-3-control-v1-1-1/)**

Este paquete trae 8 módulos para distintos componentes Lutron (Areas, Zones, Buttons, LEDs, Shades, Fans, Lumaris CCT, Lumaris RGB). En este proyecto solo se usan dos:

- `Lutron RadioRA 3 Command Processor v1.1.1.umc` — única instancia de comunicación TCP/IP con el procesador Lutron (autenticación con username/password)
- `Lutron RadioRA 3 Zone Control v1.1.1.umc` — control de cada zona en modo `Switch` (encendido/apagado discreto)
- `Lutron.Leap.CommLib.clz` — librería SIMPL# requerida por los módulos anteriores

> ⚠️ **Importante:** El archivo `Lutron.Leap.CommLib.clz` debe estar en la **misma carpeta** que el resto de los módulos (`ORECOControls/`) para que el proyecto compile sin errores. Si solo se copian los `.umc` se obtienen errores tipo `Cannot find SIMPL# Library`.

### Drivers custom desarrollados para este proyecto

| Archivo | Función |
|---|---|
| `AidooParser.usp` / `.ush` | Parser HTTP custom para la respuesta JSON del Aidoo Pro. Resuelve el problema de respuestas fragmentadas en chunks usando un buffer acumulativo. Reemplaza al parser por defecto del módulo AirZone. |

---

## 5. Estructura del repositorio

```
ORECOSF/
├── ORECOControls/                       Proyecto SIMPL Windows
│   ├── orecoc.smw                       Archivo principal del proyecto
│   ├── orecoc.lpz                       Programa compilado (carga al MC3)
│   ├── AidooParser.usp/.ush             Parser HVAC custom
│   ├── BluOS Unified Driver*.umc/...    Módulos BluOS
│   ├── Lutron RadioRA 3 *.umc/...       Módulos Lutron RA3
│   ├── Lutron.Leap.CommLib.clz          Librería SIMPL# requerida
│   ├── Equipment Control Destination... Módulo Ultamation (de paquete AirZone)
│   ├── Ultamation Analog to Serial...   Módulo Ultamation (de paquete AirZone)
│   └── SPlsWork/                        Archivos compilados de SIMPL+
│
├── ORECO TSR310/                        Interfaz de usuario VT Pro-e
│   ├── TSR310.vtp                       Proyecto VT Pro-e
│   ├── TSR310.sgd                       Smart Graphics Definition
│   ├── TSR310.vtz                       Touchpanel compilado
│   └── TSR310_audio2_Media Player...    Asset del Smart Object Media Player
│
├── BACKUPS/                             Backups previos a Git (ver §8)
│   ├── ORECOControls_BACKUP_antes_BluOS_driver.zip
│   ├── ORECOControls_pre_rename_2026-04-28.zip
│   ├── ORECOControls_v02_post-rename-z1_2026-04-28.zip
│   └── ORECOControls_v05_pre-video-replication_2026-04-29.zip
│
└── README.md                            Este archivo
```

### Estructura interna del archivo SIMPL (`orecoc.smw`)

```
Logic
├── S-1 : VIDEO
│   ├── S-1.1 : Z1   (23 Serial Sends + Set/Reset Latch + Toggle + Interlock)
│   ├── S-1.2 : Z2   (idéntica estructura)
│   └── S-1.3 : Z3   (idéntica estructura)
│
├── S-2 : HVAC
│   └── (Aidoo Parser + lógica de control compartida)
│
├── S-3 : AUDIO
│   ├── S-3.1 : Z1   (incluye AUDIO_DRIVER → BluOS Wrapper)
│   ├── S-3.2 : Z2
│   └── S-3.3 : Z3
│
├── S-4 : SYSTEM_INIT
│
├── S-5 : ILUMINACION
│   └── S-5.1 : LUTRON_DRIVER
│       ├── S-5.1.1 : Command Processor (uno solo, compartido)
│       ├── S-5.1.2 : Zone Control - Z1 (modo Switch)
│       ├── S-5.1.3 : Zone Control - Z2 (modo Switch)
│       └── S-5.1.4 : Zone Control - Z3 (modo Switch)
│
└── S-6 : Smart Graphics Modules
    ├── S-6.1 : MSOR Z1 (TSR-310 IP-ID-03)
    ├── S-6.2 : MSOR Z2 (TSR-310 IP-ID-04)
    └── S-6.3 : MSOR Z3 (TSR-310 IP-ID-05)
```

---

## 6. Convenciones del proyecto

### Nomenclatura de signals

| Tipo de signal | Prefijo | Ejemplos |
|---|---|---|
| Aislado por zona | `Z1_`, `Z2_`, `Z3_` | `Z1_Audio_VolUp`, `Z2_TV_Power`, `Z3_Lut_All_On` |
| Compartido entre zonas | (sin prefijo) | `Airzone_IsOn_FB`, `AC_Temp_Display`, `Lutron_Is_Communicating` |

### Asignación de IP-IDs

| IP-ID | Componente |
|---|---|
| 03 | TSR-310 Z1 |
| 04 | TSR-310 Z2 |
| 05 | TSR-310 Z3 |
| 06 | TCP/IP Client Samsung Z1 |
| 07 | TCP/IP Client Aidoo HVAC |
| 08 | TCP/IP Client BCS300 Z1 |
| 09 | TCP/IP Client Samsung Z2 |
| 0A | TCP/IP Client Samsung Z3 |
| 0B | TCP/IP Client BCS300 Z2 |
| 0C | TCP/IP Client BCS300 Z3 |

> **Nota sobre Lutron:** El módulo `Command Processor v1.1.1` no requiere un `TCP/IP Client` en Slot-02. Se conecta directamente al procesador Lutron usando los parámetros internos del módulo (`IPAddress`, `Username`, `Password`).

### Protocolos y puertos

| Subsistema | Protocolo | Puerto |
|---|---|---|
| BluOS (audio) | CRPC sobre TCP | 48005 / 48006 / 48007 |
| Aidoo (HVAC) | HTTP REST `POST /api/v1/hvac` | 3000 |
| Samsung (video) | MDC sobre TCP | 1515 |
| Lutron (luces) | LEAP sobre TCP | 23 |

---

## 7. Estado actual y trabajo pendiente

### ✅ Implementado y compilando limpio

- Video Z1, Z2, Z3 (Serial Sends + feedback con Toggle/Latch/Interlock)
- Audio Z1, Z2, Z3 (BluOS Wrapper + MSOR + Smart Object Media Player visual)
- HVAC compartido (Aidoo Parser custom resolviendo el JSON fragmentado)
- Iluminación Z1, Z2, Z3 (Lutron Command Processor + 3 Zone Controls en modo Switch)
- Refactor de namespacing completo (todos los signals aislados con prefijo `Z*_`)

### 🟡 Listo en código, pendiente de validación con hardware real

- IPs de Z2/Z3 BCS300 son **placeholders** (`.212`, `.213`)
- IP del procesador Lutron es **placeholder** (`192.168.0.50`)
- Credenciales del Lutron (`admin/admin`) son **placeholders** — los reales vendrían del integrador Lutron en sitio
- `Zone_Href_ID = 1, 2, 3` en los Zone Controls de Lutron son **placeholders** — los reales vienen del Integration Report exportado desde RA3 Designer
- Sin AC físico conectado al Aidoo: `AC_Temp_Display` queda en `-- °C` hasta haber comunicación real

### ⚪ Sin empezar

- Persianas Somfy (esperando módulo o protocolo definitivo)
- Validación end-to-end en sitio físico con todos los dispositivos reales

---

## 8. Backups previos a Git

Antes de versionar este proyecto en Git, se mantenían **respaldos manuales** comprimidos en `.zip` después de cada hito importante. Esos archivos siguen disponibles dentro de la carpeta `BACKUPS/` por valor histórico:

| Archivo | Hito |
|---|---|
| `ORECOControls_BACKUP_antes_BluOS_driver.zip` | Estado inicial heredado, antes de integrar BluOS |
| `ORECOControls_pre_rename_2026-04-28.zip` | Antes del refactor de namespacing (`Audio_*` → `Z1_Audio_*`) |
| `ORECOControls_v02_post-rename-z1_2026-04-28.zip` | Después de renombrar Z1, antes de Z2/Z3 |
| `ORECOControls_v05_pre-video-replication_2026-04-29.zip` | Antes de replicar Video a Z2/Z3 |

> **Importante:** A partir de ese punto, todos los hitos siguientes se versionan **directamente en Git** mediante commits y ramas. **No se generaron `.zip` adicionales después de migrar al repositorio**, así que cualquier estado posterior a esos archivos está disponible solo en el historial de Git. Los `.zip` actuales se conservan únicamente como referencia histórica.

---

## 9. Cómo reutilizar partes de este proyecto

Este repositorio puede servir como base o referencia para otros sistemas Crestron multi-zona. Algunas piezas son particularmente reutilizables:

### Patrón de namespacing por zona

El uso sistemático de prefijos `Z1_/Z2_/Z3_` para signals aislados (audio, video, iluminación) y signals sin prefijo para compartidos (HVAC) es un patrón aplicable a cualquier proyecto multi-zona. Permite que el `.vtp` siga siendo único y la diferenciación se haga en SIMPL.

### Aidoo Parser (`AidooParser.usp`)

Si se trabaja con Aidoo Pro de Airzone y se enfrenta el problema del JSON fragmentado en la respuesta HTTP, este parser custom resuelve el caso usando un buffer acumulativo. Está en `ORECOControls/AidooParser.usp`.

### Estructura del LUTRON_DRIVER

El subsistema `S-5.1` muestra cómo conectar:
- 1 Command Processor + N Zone Controls (uno por zona)
- Mismo `Command_Processor_ID = 1` para todos los Zone Controls
- `Zone_Mode = Switch` para casos de encendido/apagado discreto
- Pines `Switch_On`, `Switch_Off`, `Switch_On_Fb`, `Switch_Off_Fb` cableados directamente a los signals `Z*_Lut_All_*`

Si en otro proyecto las luces requieren dimming progresivo en lugar de encendido binario, se cambia `Zone_Mode = Dim` y se usan los pines `DimLevel_Raise`, `DimLevel_Lower` y `Set_DimLevel`.

### Replicación de Serial Sends para Video

El subsistema `S-1` muestra cómo replicar 23 Serial Sends idénticos a tres zonas con renames sistemáticos (`Z1_TV_*` → `Z2_TV_*` → `Z3_TV_*`) y cómo manejar el feedback **sin parser dedicado** (con Toggle, Set/Reset Latch e Interlock para emular estados de power, input y mute).

---

## Ramas del repositorio

- **`main`** — estado validado y compilando limpio. Estable.
- **`feat/iluminacion-aislada-z1z2z3`** — rama activa para la integración Lutron. Contiene los placeholders pendientes y se mergeará a `main` cuando se valide con hardware real.

---

## Última actualización

Documento generado con el estado del proyecto al 5 de mayo de 2026.

---

> *Proyecto desarrollado con fines educativos y de portafolio. Todos los drivers de terceros se obtuvieron del Crestron Application Market y se mencionan aquí únicamente como referencia, respetando los términos de uso individuales de cada vendor.*
