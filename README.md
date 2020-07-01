![logo](Images/logo.png)

# Présentation
Unity est un moteur de jeu multiplateforme (smartphone, ordinateur, consoles de jeux vidéo et Web) développé par Unity Technologies. Il est l'un des plus répandus dans l'industrie du jeu vidéo, aussi bien pour les grands studios que pour les indépendants du fait de sa rapidité aux prototypages et qu'il permet de sortir les jeux sur tous les supports.

Il a la particularité de proposer une licence gratuite dite « Personal » avec quelques limitations de technologie avancée au niveau de l'éditeur, mais sans limitation au niveau du moteur.

Dans le cadre d'une utilisation d'un casque de réalité virtuel (Oculus Quest) pour la safety box, nous avons prototypé sur Unity.

# Installation et Préparation de Unity VR
Pour commencer télécharger Unity Hub et Unity Editor [ici](https://unity3d.com/fr/get-unity/download),
pendant le téléchargement il vous proposera plusieurs modules à installer en plus comme Visual studio, android, ios ... Sélectionner Visual studio et android et laisser le reste par défault.

### Setup
Avant de commencer à développer sur Unity, il faut faire quelques préparations:
1. En premier il faut changer de plateforme d'exportation et passer sur Android, (car l'Oculus Quest est sous une base android, il faut donc lui envoyer des fichiers APK). Aller dans l'onglet file/Build Settings, ensuite sélectionner Android et cliquer sur switch platform.

![android](Images/android.png)

2. Ensuite nous devons paramétrer Unity de tel sorte à ce qu'il supporte la réalité virtuel. Vous devez aller dans edit/Project Settings, ensuite dans l'onglet Player et sélectionner Android et pour finir XR Settings, cocher Virtual Reality supported et avec le + ajouter Oculus.  

![player](Images/player.png)   ![oculus](Images/oculus.png)

3. Pour finir il faut importer un package, donc on va dans Window/Asset Store et dans la barre de recherche taper "Oculus Integration" et importer le.

![integration](Images/integration.png)

Maintenant tout est en place pour commencer à développer sur Unity.

# Premier pas sur Unity
Nous avons plusieurs onglets notre scene, le point de vu de notre camera, le dossier de notre projet, l'inspector et la hierarchie de notre projet.

Commençons par créer notre environnement de test, tout d'abord on supprime "main camera" dans Hierarchy, car nous utiliserons une camera adapté pour la réalité virtuel. Ensuite dans la barre de recherche de project taper "OVRPlayerController" et faire un glisser déposer du modèle dans Hierarchy. Ensuite avec Inspector on met la position à 0 pour x,z et z pour centrer notre caméra.

Pour continuer faites un clic droit dans hierarchy puis créer un "plane" et un "cube" avec 3D object, après mettre leurs positions à 0. Et enfin on crée d'autres cubes plus petit et on agrandi le premier (Bonus : dans l'Asset du project, créer un "material" Red et Black, Et attribuer ces couleurs et avec un glisser déposer sur le grand cube et sur le sol) pour obtenir ceci :

![scene](Images/scene.png)

Ensuite on clic sur OVRPlayerController, dans l'inspector on fait "Add Component" et on écrit "camera constraint" une fois ajouté on fait un glissé déposer de "OVRCameraRig" dans Camera Rig (voir ci-dessous).

![hierarchy](Images/hierarchy.png) ![constraint](Images/constraint.png)

Pour finir on sélectionne tout nos petit cubes et dans inspector on fait "Add Component" on ajoute OVR Grabbable et Rigidbody. Et voilà, il ne nous reste plus qu'à l'exporter et c'est finis.

![cube](Images/cube.png) ![grab](Images/grab.png)

Pour l'exporter, il suffit d'aller dans file/Build Settings et ensuite on clic sur build. 

![error](Images/error.png)

Aie des erreurs sont apparues! Pour régler cela et exporter notre projet au format APK, il faut dans edit/Project Settings ensuite dans l'onglet Player sélectionner Android et dans Other Settings cliquer sur Vulkan puis - pour le supprimer. Maintenant on retourne sur l'onglet et le build marche correctement.

![vulcan](Images/vulcan.png)

# Installer le test sur l'Oculus Quest
Pour pouvoir installer notre test, il faut d'abord mettre notre Oculus en mode développeur pour lui faire accepter les sources inconnues. Ensuite l'installer par le biais d'une application.

### Configuration de l'Oculus Quest en mode développeur
1. Aller sur https://dashboard.oculus.com/ et connecter vous.
2. Créer une nouvelle organisation.
3. Ajouter un nom a votre organisation.
4. Lancer l'application Oculus depuis votre téléphone. Dans les paramètres, selectionner votre casque, connecter vous via Bluetooth, Ensuite cliquer sur Autres Paramètres/ Développeur et activer le.

 ![nom](Images/nom.PNG)


### SideQuest
SideQuest est un outil permettant aux développeurs d’applications VR de proposer leurs jeux sur Oculus Quest sans l’approbation de Facebook. Il permet aussi de mettre ses projets APK sur son Quest.

Pour installer SideQuest : https://sidequestvr.com/

### Connection à SideQuest
Pour Installer notre fichier APK sur l'Oculus, il faut connecter le casque au PC avec un cable usb. Une fois branché lancer l'application SideQuest et si tout vas bien l'oculus est connecté au PC.

![connected](Images/connected.png)

Si vous n'etes pas connecté vous aurez besoin d'accepter des autorisations depuis le casque. ![unauthorized](Images/unauthorized.png)

### Installation de notre premier test
Pour installer notre test nous utiliserons uniquement ces deux icones (celle de gauche pour installer des APK et l'autre pour désinstaller des fichiers de notre casque). 

![barre](Images/barre.png)

On clique sur l'icone de gauche et on sélectionne le fichier APK que l'on a build précédement. Un message apparait en bas une fois le téléchargement terminé. Pour regarder les tâches en cours il suffit de cliquer sur l'icone de liste avec un v. Une fois cela fais il ne nous reste plus qu'à aller dans la bibliothèque de notre casque ensuite source inconnues et enfin de lancer notre test. 

Mais faire cela à chaque fois que l'on souhaite tester notre projet cela deviens long, c'est pourquoi il existe une façon de tester sans perdre tout ce temps. La solution l'Oculus Link.

# Oculus Link
Oculus Link permet de brancher votre Oculus Quest sur votre PC via un câble USB afin que ce dernier soit reconnu comme un Oculus Rift Standard. Le but étant de pouvoir accéder à son ordinateur via le casque, mais aussi d’avoir accès à des jeux et applications plus gourmandes en exploitant la puissance de votre ordinateur. 

### Configuration
Oculus Link nécessite un câble USB de haute qualité. Il est recommandé d’utiliser un câble USB 3.0 de type C à C ou de type A à C de haute qualité et aux performances reconnues, mais aussi avoir une certaine configuration PC voir [ici](https://support.oculus.com/444256562873335/).

Pour se connecter rien de plus simple, une fois votre casque reconnu par l’application PC, l’Oculus détecte automatiquement votre ordinateur et vous propose de passer sur la fonctionnalité Oculus Link Beta. En acceptant, vous vous retrouvez dans l’environnement VR propre à l’Oculus Rift avec un accès complet à son catalogue de jeux.

# Projet Setup
Ce petit projet a pour but de tester plusieurs choses, voir ce qu'il est possible de faire, prototyper.

### Configuration de la caméra

#### Préfabs
En important Oculus Integration depuis l'Asset Store, nous avons accès à "OVRPlayerController" ce qui fait que nous n'avons besoin de configurer uniquement le tracking origin mode (pour régler la caméra en fonction de la distance du casque et du sol).

#### Manuel
1. Créer un "Empty" dans Hierarchy, et renommer le VR Rig.
2. Faites "Add Component" et taper XR Rig.
3. Créer une caméra "Camera Offset" à la racine de VR Rig, et une autre caméra "VR camera" à la racine de l'autre caméra et avec "Add Component" ajouter Tracked Pose Driver.
4. faites un glisser déposer des caméras dans le component XR Rig de l'Empty.

![empty](Images/empty.png) ![xr](Images/xr.png)

### Configuration des mains

#### Préfabs
importer CustomHandLeft and Right pour ensuite appliquer dans le model prefab de left hand et right hand.

![model](Images/model.png)

#### Manuel
1. Créer deux Empty à la racine de Camera Offset et renommer les Left Hand et Right Hand. 
2. Selectionner les et ajouter XR Controller avec "Add Component", configurer controller node sur right hand ou left hand en fonction de la main.

![controller](Images/controller.png)

3. Vous pouvez soit importer des mains soit en créer vous même avec des formes pour ensuite appliquer dans le model prefab de left hand et right hand.

### Grab
"Add Component" sur left hand et right hand, taper XR direct interactor et Sphere collider. Ensuite mettre le Radius à 0.2, et cocher Is Trigger.

![sphere](Images/sphere.png)

Si vous voulez attrapper un objet il suffit de lui ajouter XR Grabbable avec "Add Component".

### Interaction
Nous allons intéragir avec une porte de commode. Pour ce faire installer la [ici](https://drive.google.com/file/d/18AU3DCQzmYgYekg_0-VYmnOQOcV7mftR/view). Une fois téléchargé et importé sur Unity sélectionner Door dans Cabinet et avec "Add Component" ajouter XR Grabbable, puis faire un glissé déposé du door handler dans collider.

![door](Images/door.png) ![collider](Images/collider.png)

YouTube : [Valem](https://www.youtube.com/c/ValemVR/videos)
