Fonctionnalités de l'application GVE
1. Authentification et accès à l'application
Écran de connexion utilisateur.
Saisie du nom d'utilisateur et du mot de passe.
Gestion d'un accès administrateur distinct.
Possibilité d'accéder à l'espace administrateur via une action cachée sur le logo.
Demande de permission d'accès à la localisation du téléphone.
2. Géolocalisation des modules / colliers

C'est la fonctionnalité principale de l'application.

Localisation géographique des modules/colliers.
Récupération des coordonnées GPS via une API distante.
Affichage des positions sur une carte Google Maps.
Affichage de la position actuelle du téléphone.
Actualisation périodique de la position.
Affichage des modules sous forme de marqueurs sur la carte.
Affichage de la zone autour d'une position avec un cercle géographique.
Zoom et déplacement sur la carte.

Le modèle PositionModule confirme la gestion de :

identifiant du module ;
numéro/identifiant du collier ;
latitude ;
longitude ;
date de localisation.
3. Suivi des colliers

L'application semble conçue pour suivre des colliers connectés ou modules de localisation.

Le code prévoit notamment :

identification des colliers ;
récupération de leur position ;
affichage individuel sur la carte ;
identification des colliers par numéro ;
suivi de leur localisation dans le temps.

La page de détails prévoit également des informations telles que :

distance ;
UID ;
niveau de batterie ;
durée/temps ;
informations complémentaires.
4. Gestion des modules

L'application possède une section Liste des modules.

Elle permet :

d'afficher les modules récupérés depuis l'API ;
d'afficher leur identifiant ;
d'afficher leur numéro de collier ;
d'afficher leur libellé ;
d'accéder à une fonction d'ajout de module.

L'API utilisée dans le code est notamment :

/api/modules
5. Ajout d'un module par QR Code

Le projet intègre une fonctionnalité de lecture de QR Code.

Depuis Ajouter un module :

ouverture du scanner ;
lecture d'un QR Code ;
récupération de la valeur du QR Code ;
affichage de la valeur scannée ;
gestion d'une erreur lorsque le QR Code n'est pas valide ;
possibilité de relancer le scan.

C'est une fonctionnalité intéressante pour associer rapidement un module/collier à l'application.

6. Notifications

Une rubrique Notifications est prévue.

Elle permet d'afficher :

la date de notification ;
le message ;
une liste de notifications.

Dans la version actuelle du code, les notifications sont encore des données de démonstration et non un véritable système de notifications connecté au serveur.

7. Paramètres

Une rubrique Paramètres est présente dans l'application.

Cependant, dans la version fournie, elle contient essentiellement la structure de la page et n'implémente pas encore de fonctionnalités avancées.

8. Aide et informations

L'application possède également :

une rubrique Aide ;
une rubrique À propos ;
une page d'informations complémentaires.

Certaines de ces pages sont encore des écrans de base.

9. Communication avec une API

L'application mobile communique avec un serveur distant via des API REST.

On retrouve notamment :

https://www.ipmie.com/esp/public/index.php/api/

et des endpoints pour :

/api/modules
/api/positions
/api/position/{colier}

Les données sont récupérées au format JSON puis utilisées dans l'application mobile.

10. Application mobile multiplateforme

Le projet est développé avec :

Xamarin.Forms

et contient des projets :

GveApp.Android
GveApp.iOS
GveApp

L'application est donc structurée pour fonctionner sur :

Android
iOS

avec une base de code commune.
