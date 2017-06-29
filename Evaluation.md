Evaluation finale du cours .NET � l'IUT Lyon 1
==============================================

Crit�res d'�valuation
---------------------

* Solution apport�e aux probl�mes pos�s dans le fichier Readme.md + r�ponses aux questions (� mettre dans le fichier ci-dessous)
* La qualit� des commits : granularit� fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont �t� modifi�s, c'est inutile, Git le dit d�j�)
* La qualit� du code : utiliser un nommage correct + R# donne des r�gles � respecter, il suffit de les corriger
* Les tests unitaires : expressivit� (le nommage tout particuli�rement), granularit� (i.e on teste une chose � la fois), rapidit� (i.e instantan�), couverture de code et ind�pendance (un test ne d�pend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour �viter de faire du code difficilement maintenable et �volutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et m�thodes donn�s (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez � pousser vos commits sur votre compte GitHub et envoyer votre d�p�t � mon adresse mail.

R�ponses aux questions pos�es
-----------------------------

Q1) Pour �viter les switchs et ifs on peut utiliser un dictionnaire qui prendra en param�tre un char pour l'op�rateur et une fonction pour faire appel � l'op�ration.

Q2) On utilise le principe SRP (Single Responsability Principal)

Q3) On utilse l'inversion de d�pendance ainsi que le principe d'encapsulation des donn�es : une classe n'a acc�s uniquement aux donn�es dont elle a strictement besoin.

Q4) Dans le calculTrainer les donn�es sont saisies en dur au lieu d'�tre saisie par l'utilisateur. Le domaine et la pr�sentation ne sont pas s�par�s.

Q5) On s�pare la vue de la couche m�tier de la couche donn�e. Chaque groupe est ind�pendant. Cela facilite la maintenabilit� du code.

Q6) On utilise aussi l'inversion de d�pendance, en isolant les op�rations �crites en dur dans une classe. Cette classe n'a pas besoin de savoir les op�rations que l'on veut effectuer mais seulement appliquer ce qu'on lui donne.
 