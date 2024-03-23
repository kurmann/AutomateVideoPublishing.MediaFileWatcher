# Media File Watcher

Das Modul "Media File Watcher" ist eine Komponente der Automatisierungsplattform für private Videoproduktion, die darauf abzielt, die Effizienz und Organisation von Mediendateien zu verbessern, indem es Verzeichnisse überwacht und auf Änderungen reagiert.

## Features

- **Abstraktion des FileSystemWatcher**: Bietet eine saubere und einfache API, um Änderungen im Dateisystem zu beobachten.
- **Überwachung von Medienverzeichnissen**: Verfolgt die Erstellung, Bearbeitung, Löschung und Umbenennung von Mediendateien in Echtzeit.
- **Domänenspezifische Events**: Ermöglicht das Auslösen von benutzerdefinierten Events, die für die Domäne der Mediendateiverwaltung relevant sind.
- **Unterstützung für verschiedene Dateitypen**:
  - Neue Mediendateien (MP4, AVI, etc.)
  - Sidecar-Dateien (z.B. NFO für Metadaten-Info oder SRT für Untertitel)
  - Artwork-Dateien (Cover-Bilder, Thumbnails)

## Modulare Architekturprinzipien

Dieses Modul wurde unter Berücksichtigung der folgenden Architekturprinzipien entwickelt:

1. **Hohe Kohäsion**: Das Modul ist spezialisiert auf die Überwachung und Benachrichtigung von Dateiänderungen im Kontext von Medienverzeichnissen.
2. **Lose Kopplung**: Interaktion mit anderen Modulen erfolgt über definierte Schnittstellen und Ereignisse.
3. **Unveränderlichkeit und Validität von Entitäten**: Verwendet Factory-Methoden und Ergebnistypen, um stets einen validen Zustand zu gewährleisten.
4. **Domain-Driven Design (DDD)**: Baut auf einem Domänenmodell auf, das die Geschäftslogik widerspiegelt.
5. **Event-Driven Approach**: Nutzt Events und Delegates zur Kommunikation zwischen den Modulen.
6. **SOLID-Prinzipien**: Stellt die Qualität und Erweiterbarkeit des Codes sicher.
7. **Einfachheit und Klarheit**: Die Architektur bleibt so einfach wie möglich, ohne Funktionalität zu opfern.
8. **Modulare Monolithen**: Nutzt die Vorteile modularer Monolithen für eine ausgewogene Architektur.

## Installation

Befolgen Sie diese Schritte, um das Modul "Media File Watcher" zu installieren und in Ihre Anwendung zu integrieren:

**Fügen Sie das Modul zum Projekt hinzu**:
```bash
dotnet add package MediaFileWatcher
```
