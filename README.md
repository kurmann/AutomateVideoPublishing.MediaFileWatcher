# Media File Watcher

## Archivierung

### Dieses Repository wurde in das Monorepo "kurmann/videoschnitt" migriert

**Hinweis:** Dieses Repository wird nicht mehr aktiv weiterentwickelt und ist archiviert. Die Entwicklung wird nun im Monorepo [kurmann/videoschnitt](https://github.com/kurmann/videoschnitt) fortgeführt.

---

Das Modul "Media File Watcher" ist eine Komponente der Automatisierungsplattform für private Videoproduktion, die darauf abzielt, die Effizienz und Organisation von Mediendateien zu verbessern, indem es Verzeichnisse überwacht und auf Änderungen reagiert.

## Installation

```
dotnet add package Kurmann.Videoschnitt.MediaFileWatcher
```

## Features

- **Abstraktion des FileSystemWatcher**: Bietet eine saubere und einfache API, um Änderungen im Dateisystem zu beobachten.
- **Überwachung von Medienverzeichnissen**: Verfolgt die Erstellung, Bearbeitung, Löschung und Umbenennung von Mediendateien in Echtzeit.
- **Domänenspezifische Events**: Ermöglicht das Auslösen von benutzerdefinierten Events, die für die Domäne der Mediendateiverwaltung relevant sind.
- **Unterstützung für verschiedene Dateitypen**:
  - Neue Mediendateien (MP4, AVI, etc.)
  - Sidecar-Dateien (z.B. NFO für Metadaten-Info oder SRT für Untertitel)
  - Artwork-Dateien (Cover-Bilder, Thumbnails)

## Integration

In eine Host .NET-Anwendung

```csharp
services.AddMediaFileWatcher(servicesSettings);
```
