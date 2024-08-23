# Unity AR Project with Vuforia Engine

## Overview

This Unity AR project uses the Vuforia Engine to create an interactive augmented reality experience. By leveraging Vuforia's image recognition capabilities, the application detects specific database images representing different chemical atoms. When these images are placed in proximity, the atoms dynamically form a 3D model of a chemical compound based on their valency. The atoms and bonds hover over the database images, providing a visually engaging educational tool for learning about chemical compounds.

Additionally, the project includes a feature where the Vuforia Engine detects 3D models or objects, such as bags, and overlays AR content accordingly.

## Features

- **Image Recognition:** Utilizes Vuforia's image tracking to recognize and track multiple images representing different chemical atoms.
- **Dynamic Atom Formation:** When multiple database images are detected together, the corresponding atoms combine to form a specific compound, considering the valency of each atom.
- **Interactive AR Visualization:** Atoms and bonds are rendered in 3D, hovering over the detected images to provide an interactive learning experience.
- **3D Model Detection:** The application can also detect physical models or objects, such as a bag, and overlay AR content on or around them.

## Requirements

- **Unity:** Version 2021.3 or higher.
- **Vuforia Engine:** Latest SDK compatible with Unity.
- **Supported Platforms:** iOS, Android
- **AR-Compatible Device:** A mobile device with a camera and support for AR capabilities.
