![logo](Images/logo.png)

# Présentation
Unity est un moteur de jeu multiplateforme (smartphone, ordinateur, consoles de jeux vidéo et Web) développé par Unity Technologies. Il est l'un des plus répandus dans l'industrie du jeu vidéo, aussi bien pour les grands studios que pour les indépendants du fait de sa rapidité aux prototypages et qu'il permet de sortir les jeux sur tous les supports.

Il a la particularité de proposer une licence gratuite dite « Personal » avec quelques limitations de technologie avancée au niveau de l'éditeur, mais sans limitation au niveau du moteur.

Dans le cadre d'une utilisation d'un casque de réalité virtuel (Oculus Quest) pour la safety box, nous avons prototypé sur Unity.

# Installation et Préparation de Unity
Pour commencer télécharger Unity Hub et Unity Editor [ici](https://unity3d.com/fr/get-unity/download),
pendant le téléchargement il vous proposera plusieurs modules a installer en plus comme Visual studio, android, ios ... Sélectionner Visual studio et android et laisser le reste par défault.

### Setup
Avant de commencer à développer sur Unity, il faut faire quelques préparations:
1. En premier il faut changer de plateforme d'exportation et passer sur Android, (car l'oculus quest est sous une base android, il faut donc lui envoyer des fichiers APK). Aller dans l'onglet file/Build Settings, ensuite sélectionner Android et cliquer sur switch platform.

![android](Images/android.png)

2. Ensuite nous devons paramétrer Unity de tel sorte à ce qu'il supporte la réalité virtuel. Vous devez aller dans edit/Project Settings, après aller dans l'onglet Player et sélectionner Android et dans XR Settings cocher Virtual Reality supported et avec le + ajouter Oculus.  

![player](Images/player.png)   ![oculus](Images/oculus.png)

3. Pour finir il faut importer un package, Window/Asset Store et dans la barre de recherche taper "Oculus Integration" et importer le.

![integration](Images/integration.png)

Maintenant tout est en place pour commencer à développer sur Unity.

# Premier pas sur Unity
Nous avons plusieurs onglets notre scene, le point de vu de notre camera, le dossier de notre projet, l'inspector et la hierarchie de notre projet.

Commençons par créer notre environnement de test, tout d'abord on supprime "main camera" dans Hierarchy, ensuite dans la barre de recherche de project taper "OVRPlayerController" et faire un glisser déposer du modèle dans Hierarchy. Ensuite avec Inspector on met la position à 0 pour x,z et z.

On continue avec un clic droit dans hierarchy puis on créer un "plane" et un "cube" avec 3D object et mettre leurs positions à 0. Pour finir on crée d'autres cubes plus petit et on agrandi le premier (Bonus : dans l'Asset du project on peut créer un "material", lui attribuer une couleur et avec un glisser déposer le mettre sur le grand cube) pour obtenir ceci :

![scene](Images/scene.png)

Ensuite on clic sur OVRPlayerController et dans l'inspector on fait "Add Component" et on tape "camera constraint" une fois ajouté on fait un glissé déposer de "OVRCameraRig" dans Camera Rig voir

![hierarchy](Images/hierarchy.png) ![constraint](Images/constraint.png)

Pour finir on sélectionne tout nos petit cubes et dans inspector on clic "Add Component" on ajoute OVR Grabbable et Rigidbody. Et voilà il ne nous reste plus qu'à l'exporter et c'est finis.

![cube](Images/cube.png) ![grab](Images/grab.png)

# Première exportation vers l'Oculus Quest
Pour exporter il suffit d'aller dans file/Build Settings et ensuite on clic sur build. 

![error](Images/error.png)

Aie des erreurs sont apparues! Pour régler ces erreurs et pouvoir exporter notre projet au format APK, il faut aller dans edit/Project Settings après dans l'onglet Player sélectionner Android et dans Other Settings cliquer sur Vulkan puis - pour le supprimer. Maintenant on retourne sur l'onglet et le build marche correctement.

![vulcan](Images/vulcan.png)

### Configuration de l'Oculus Quest en mode développeur
Tout d'abord il vous faut installer l'application Oculus sur votre téléphone activez le Wi-Fi et le Bluetooth et suivre les explications. Ensuite un fois le casque connecté vous devrez aller dans Autres Paramètres/Mode Développeur et en l'activant on est redirigé sur une page il faut se connecter et créer une organisation. Et maintenant il ne nous reste plus qu'à revenir sur l'application et activer le mode développeur.

![4](Images/4.PNG) ![3](Images/3.PNG) ![2](Images/2.PNG) ![1](Images/1.PNG)


### Installation de SideQuest

### Exportation et installation de notre premier test

# Oculus Link
Oculus Link permet de brancher votre Oculus Quest sur votre PC via un câble USB afin que ce dernier soit reconnu comme un Oculus Rift Standard. Le but étant de pouvoir accéder à son ordinateur via le casque, mais aussi d’avoir accès à des jeux et applications plus gourmandes en exploitant la puissance de votre ordinateur. 

### Configuration
Oculus Link nécessite un câble USB de haute qualité. Il est recommandé d’utiliser un câble USB 3.0 de type C à C ou de type A à C de haute qualité et aux performances reconnues, mais aussi avoir une certaine configuration PC voir [ici](https://support.oculus.com/444256562873335/).

Pour se connecter rien de plus simple, une fois votre casque reconnu par l’application PC, l’Oculus détecte automatiquement votre ordinateur et vous propose de passer sur la fonctionnalité Oculus Link Beta. En acceptant, vous vous retrouvez dans l’environnement VR propre à l’Oculus Rift avec un accès complet à son catalogue de jeux.

