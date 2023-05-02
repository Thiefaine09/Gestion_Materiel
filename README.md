# Gestion_Materiel
Gestionnaire de matériel en C# (WindowsForm)
Introduction au projet



La société "GestionMatos" est une entreprise spécialisée dans la maintenance d'équipements informatiques. 
Elle travaille pour le compte de plusieurs sociétés clientes réparties sur divers sites en France. Les équipements informatiques de ces clients nécessitent une maintenance régulière pour assurer leur bon fonctionnement et éviter les pannes imprévues. 
La maintenance peut être préventive, programmée à l'avance pour éviter toute panne, urgente, calculée sur la base du MTBF (temps moyen entre deux pannes) du matériel et curative, suite à une panne. Afin de gérer efficacement les interventions, la société dispose d'un ensemble d'intervenants répartis sur tout le territoire français.
 Ces intervenants sont chargés de réaliser les interventions de maintenance sur site ou à distance en fonction de la nature des équipements et de la maintenance à effectuer. Pour améliorer l'efficacité de son activité, la société "GestionMatos" a décidé de se doter d'un logiciel de gestion des interventions. 
Ce logiciel permettra de gérer l'ensemble des équipements informatiques de ses clients ainsi que les interventions préventives, urgentes et curatives.


Cahier des charges :

Voici un détail des fonctionnalités de l'application Windows Form GestionMatos:

Gestion du matériel :


Ajout, modification et suppression de matériel avec ses informations associées (numéro de série, client, MTBF, date 	d'intervention, nom, description, type et site).
 	
Recherche de matériel par type, client, numéro de série, site et date de dernière intervention.
 	
Affichage de la durée restante avant la fin du MTBF pour chaque matériel.


Gestion des clients :


Ajout, modification et suppression de clients avec leurs informations associées (nom, adresse, numéro de téléphone, 	etc.).
 	
Recherche de clients par nom ou adresse.


Programmation et validation des interventions:


Programmation d'une intervention en associant un matériel, une date planifiée et un champ de commentaire.
 	
Validation d'une intervention une fois le travail terminé.
 	
Levée 	d'alertes pour chaque matériel dont le MTBF depuis la dernière intervention va être atteint.


Consultation des interventions:


Consultation des interventions prévues et réalisées, filtrées par client, matériel, type de matériel ou site.


L’application dispose également d’un accès sécurisé par mot de passe.

Installation 
Prérequis 
Avant de pouvoir installer l'application, vous devez vous assurer que les prérequis suivants sont installés sur votre système: 

-Visual Studio Community 2022
-MS SQL Server 2019 Express 
-SQL Server Management Studio 

Étapes d'installation : 

-Clonez le dépôt GitHub sur votre machine locale.
-Ouvrez le projet dans Visual Studio Community 2022.
-Ouvrez le fichier app.config et modifiez les paramètres de connexion à la base de données selon vos besoins.
-Compilez le projet et vérifiez qu'il n'y a pas d'erreurs. 
-Ouvrez SQL Server Management Studio et connectez-vous à votre instance SQL Server. 
-Créez une nouvelle base de données avec un nom de votre choix. 
-Exécutez le script de création de la base de données fourni dans le dossier "SQL Scripts" pour créer les tables nécessaires.
-Ouvrez l'application et vérifiez que tout fonctionne correctement.
-Utilisation L'application permet de gérer l'inventaire d'un parc informatique et de gérer les interventions nécessaires sur celui-ci.

Voici les étapes pour l'utiliser: 

-Ajouter un matériel Cliquez sur le bouton "Matériels" dans le menu principal.
-Cliquez sur le bouton "Ajouter un nouveau matériel". 
-Remplissez les informations sur le matériel (numéro de série, client, MTBF, nom, description, type, site). 
-Cliquez sur le bouton "Enregistrer". 
-Planifier une intervention Cliquez sur le bouton "Interventions" dans le menu principal.
-Cliquez sur le bouton "Planifier une nouvelle intervention". 
-Sélectionnez le matériel pour lequel vous souhaitez planifier l'intervention.
-Remplissez les informations sur l'intervention (numéro d'intervention, date planifiée, commentaire).
-Cliquez sur le bouton "Enregistrer". Marquer une intervention comme réalisée Cliquez sur le bouton "Interventions" dans le menu principal. 
-Sélectionnez l'intervention que vous souhaitez marquer comme réalisée. 
-Cliquez sur le bouton "Marquer comme réalisée". 
-Remplissez les informations sur l'intervention réalisée (date, commentaire). 
-Cliquez sur le bouton "Enregistrer".
-Modifier un matériel Cliquez sur le bouton "Matériels" dans le menu principal. Sélectionnez le matériel que vous souhaitez modifier.
-Cliquez sur le bouton "Modifier". 
-Modifiez les informations sur le matériel selon vos besoins.
-Cliquez sur le bouton "Enregistrer". Supprimer un matériel -Cliquez sur le bouton "Matériels" dans le menu principal. -Sélectionnez le matériel que vous souhaitez supprimer. 
-Cliquez sur le bouton "Supprimer". 
-Confirmez la suppression en cliquant sur "Oui" dans la boîte de dialogue qui apparaît.
-Afficher les matériaux ou les interventions -Cliquez sur le bouton “Matériels”.
