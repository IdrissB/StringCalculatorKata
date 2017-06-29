Evaluation finale du cours .NET à l'IUT Lyon 1
==============================================

Critères d'évaluation
---------------------

* Solution apportée aux problèmes posés dans le fichier Readme.md + réponses aux questions (à mettre dans le fichier ci-dessous)
* La qualité des commits : granularité fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont été modifiés, c'est inutile, Git le dit déjà)
* La qualité du code : utiliser un nommage correct + R# donne des règles à respecter, il suffit de les corriger
* Les tests unitaires : expressivité (le nommage tout particulièrement), granularité (i.e on teste une chose à la fois), rapidité (i.e instantané), couverture de code et indépendance (un test ne dépend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour éviter de faire du code difficilement maintenable et évolutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et méthodes donnés (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez à pousser vos commits sur votre compte GitHub et envoyer votre dépôt à mon adresse mail.

Réponses aux questions posées
-----------------------------

Q1) Pour éviter les switchs et ifs on peut utiliser un dictionnaire qui prendra en paramètre un char pour l'opérateur et une fonction pour faire appel à l'opération.

Q2) On utilise le principe SRP (Single Responsability Principal)

Q3) On utilse l'inversion de dépendance ainsi que le principe d'encapsulation des données : une classe n'a accès uniquement aux données dont elle a strictement besoin.

Q4) Dans le calculTrainer les données sont saisies en dur au lieu d'être saisie par l'utilisateur. Le domaine et la présentation ne sont pas séparés.

Q5) On sépare la vue de la couche métier de la couche donnée. Chaque groupe est indépendant. Cela facilite la maintenabilité du code.

Q6) On utilise aussi l'inversion de dépendance, en isolant les opérations écrites en dur dans une classe. Cette classe n'a pas besoin de savoir les opérations que l'on veut effectuer mais seulement appliquer ce qu'on lui donne.
 