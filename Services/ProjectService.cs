using global::PortfolioTamere.Models;

namespace PortfolioTamere.Services
{
    public class ProjectService
    {
        private readonly List<Project> _projects = new()
        {
             new Project
            {
                Id = "watchdog",
                Title = "Watchdog API",
                Description = "API .NET 8 KYC/AML avec scoring, PPE, sanctions, anomalies.",
                Technologies = ".NET 8, EF Core, SQL Server, Azure",
                Url = "https://github.com/keekee3091/Watchdog",
FullDescription = @"
<h3><strong>Présentation</strong></h3>
<p>
Watchdog est un moteur KYC/AML complet développé comme projet personnel, pensé comme une 
mini-plateforme de conformité inspirée des environnements bancaires. 
L’objectif était simple : <strong>simuler un vrai moteur réglementaire</strong>, capable de 
centraliser des données hétérogènes, d’exécuter un scoring structuré et de détecter des signaux 
suspects de manière totalement autonome.
</p>
<p>
Le projet m’a servi de terrain d’expérimentation pour explorer des problématiques rarement abordées 
en dehors du monde financier : normalisation de données sensibles, règles métiers complexes, 
détection d’anomalies, architecture hexagonale, performance, auditabilité et conteneurisation.
</p>

<h3 class='mt-4'><strong>Lancement du projet</strong></h3>
<p>
Watchdog est né de l’envie de reproduire, à échelle réduite, le fonctionnement d’un système 
de conformité professionnel. Sans dépendre de sources réelles, j’ai construit des <strong>modules 
simulateurs</strong> capables de générer des données proches des flux KYC : PPE, sanctions, comportements 
anormaux, incohérences déclaratives.
</p>
<p>
L’idée était de pouvoir tester différentes approches de scoring, affiner des règles métiers 
et valider des schémas d’architecture propres aux projets sensibles : traçabilité, logs, 
isolation des couches, validation stricte et robustesse technique.
</p>

<h3 class='mt-4'><strong>Les étapes</strong></h3>
<p>
• Définition d’un modèle de scoring : signaux faibles, critères pondérés, règles d’alerte.<br/>
• Mise en place de l’architecture hexagonale (Domain / Application / Infrastructure).<br/>
• Développement du moteur de scoring et des simulateurs de sources externes.<br/>
• Normalisation des données pour garantir un pipeline cohérent, quelle que soit la source.<br/>
• Ajout d’un système de logs explicables, orientés audit, et d’une historisation des analyses.<br/>
• Conteneurisation, tests unitaires, optimisation du cache et des performances globales.
</p>

<h3 class='mt-4'><strong>Les résultats</strong></h3>

<h4><strong>Pour moi</strong></h4>
<p>
Watchdog m’a permis de pratiquer une architecture de niveau industriel dans un cadre totalement libre. 
J’ai pu m’exercer à la modélisation de règles métiers complexes, à la structuration d’un moteur autonome, 
et à la construction d’un socle technique équivalent à ce qu’on trouve dans les fintechs et institutions 
réglementées.
</p>

<h4 class='mt-3'><strong>Pour le projet</strong></h4>
<p>
Le moteur est aujourd’hui stable, modulaire et capable d’ingérer des données hétérogènes pour produire 
une analyse réglementaire structurée. Watchdog sert de base à d’autres expérimentations : scénarios de 
fraude, modèles statistiques, outils internes de test ou prototypes réglementaires.
</p>

<h3 class='mt-4'><strong>Insights & KPIs</strong></h3>
<div class='row row-cols-1 row-cols-md-3 g-4'>
    <div class='col'>
        <div class='card text-center shadow-sm h-100'>
            <div class='card-body'>
                <h5 class='card-title'>40 ms</h5>
                <p class='card-text'>Temps de réponse moyen de l’API en charge nominale.</p>
            </div>
        </div>
    </div>
    <div class='col'>
        <div class='card text-center shadow-sm h-100'>
            <div class='card-body'>
                <h5 class='card-title'>1 800 req/min</h5>
                <p class='card-text'>Débit maximal simulé pour les scénarios intensifs.</p>
            </div>
        </div>
    </div>
    <div class='col'>
        <div class='card text-center shadow-sm h-100'>
            <div class='card-body'>
                <h5 class='card-title'>> 95 %</h5>
                <p class='card-text'>Cohérence métier du scoring sur les scénarios complexes.</p>
            </div>
        </div>
    </div>
</div>

<h3 class='mt-4'><strong>Les lendemains du projet</strong></h3>
<p>
Les pistes d’évolution incluent l’intégration de sources réelles, de modèles statistiques, de 
détection comportementale, et la connexion avec des jeux de données réglementaires publics. 
L’architecture actuelle permet d’étendre facilement le moteur et de tester de nouvelles logiques métier.
</p>
",    },
            new Project
            {
                Id = "volatiq",
                Title = "VolatiQ",
                Description = "Analyseur quantitatif de micro-volatilité (GBM, Monte Carlo, signaux, anomalie).",
                Technologies = "C++, .NET, Python, Quant",
                Url = "https://github.com/keekee3091/black_scholesEU",
FullDescription = @"
<h3><strong>Présentation</strong></h3>
<p>
VolatiQ est un analyseur quantitatif construit autour d’un pipeline hybride 
<strong>Python + C++</strong>. 
L’objectif : disposer d’un outil local capable de récupérer des données d’options, 
de les valoriser en temps réel et d’identifier des signaux de micro-volatilité 
à l’aide de modèles quantitatifs tels que <strong>Black-Scholes</strong> et les grecs.
</p>
<p>
Le projet combine la souplesse de Python (yfinance, FastAPI, mise en cache) 
et la vitesse brute du C++ (Crow, Python C API). 
L’ensemble crée un environnement performant, pensé pour reproduire une chaîne 
de valorisation d’options simple, réactive et extensible.
</p>

<h3 class='mt-4'><strong>Lancement du projet</strong></h3>
<p>
L’idée est née d’un constat : obtenir des données d’options fiables, rapides et gratuites 
est complexe. Les APIs limitées, les quotas et le manque d’outils locaux m’ont motivé à 
construire une solution autonome. 
VolatiQ devait donc :
</p>
<ul>
    <li>récupérer efficacement les options (calls / puts, maturités, volatilités),</li>
    <li>mettre en cache localement pour éviter les limites API,</li>
    <li>valoriser rapidement les options grâce à du C++ optimisé,</li>
    <li>détecter des anomalies de pricing ou de volatilité.</li>
</ul>

<h3 class='mt-4'><strong>Les étapes</strong></h3>
<p>
• Création d’une API Python FastAPI avec mise en cache persistante.<br/>
• Mise en place d’un fallback via proxy TOR pour contourner les limitations.<br/>
• Développement d’un serveur C++ Crow pour exécuter les calculs quantitatifs.<br/>
• Implémentation du modèle Black-Scholes : prix théoriques, Delta, Gamma.<br/>
• Création d’un score de mispricing et filtrage intelligent des séries d’options.<br/>
• Assemblage d’un pipeline complet : acquisition → filtrage → quant → scoring → API REST.
</p>

<h3 class='mt-4'><strong>Les résultats</strong></h3>

<h4><strong>Pour moi</strong></h4>
<p>
VolatiQ m’a permis d’explorer des domaines avancés : bindings Python/C++, 
calculs vectorisés, optimisation bas niveau, quantification des signaux de volatilité 
et construction de modèles analytiques. 
C’est également un excellent exercice d’architecture multi-langages.
</p>

<h4 class='mt-3'><strong>Pour le projet</strong></h4>
<p>
Le système fonctionne comme un <strong>mini-pricer local</strong>, capable de valoriser des centaines d’options 
par seconde, tout en fournissant un score utile pour repérer des anomalies dans les données. 
L’architecture est suffisamment flexible pour accueillir d’autres modèles : Heston, SABR, 
méthodes Monte-Carlo, etc.
</p>

<h3 class='mt-4'><strong>Insights & KPIs</strong></h3>
<div class='row row-cols-1 row-cols-md-3 g-4'>
    <div class='col'>
        <div class='card text-center shadow-sm h-100'>
            <div class='card-body'>
                <h5 class='card-title'>1000+ options/s</h5>
                <p class='card-text'>Débit local du moteur de pricing C++.</p>
            </div>
        </div>
    </div>
    <div class='col'>
        <div class='card text-center shadow-sm h-100'>
            <div class='card-body'>
                <h5 class='card-title'>-90 %</h5>
                <p class='card-text'>Réduction de trafic API grâce au cache persistant.</p>
            </div>
        </div>
    </div>
    <div class='col'>
        <div class='card text-center shadow-sm h-100'>
            <div class='card-body'>
                <h5 class='card-title'>5 ms</h5>
                <p class='card-text'>Temps moyen d’un pricing Black-Scholes en C++.</p>
            </div>
        </div>
    </div>
</div>

<h3 class='mt-4'><strong>Les lendemains du projet</strong></h3>
<p>
Les prochaines évolutions incluent la volatilité stochastique, une interface graphique, 
des flux temps réel via WebSockets et un moteur parallèle pour traiter des milliers d’options 
en simultané.
</p>
",            },
            new Project
            {
                Id = "crm_backoffice",
                Title = "CRM Backoffice PCi33",
                Description = "Maintenance et modernisation d’un CRM métier : optimisation SQL, refactorisation WebForms, stabilisation Telerik, fiabilisation KYC & facturation.",
                Technologies = "VB, .Net, SQL Server, Telerik",
                Url = "",
FullDescription = @"
<h3><strong>Présentation</strong></h3>
<p>
Le CRM Backoffice PCi33 est le cœur opérationnel de l’entreprise : il centralise la gestion client, 
la facturation, le support, les processus KYC, la gestion documentaire et de nombreux workflows internes. 
Il s’agit d’un système historique reposant sur <strong>VB .NET</strong>, <strong>ASP.NET WebForms</strong>, 
<strong>SQL Server</strong> et l’écosystème <strong>Telerik</strong>. 
Pendant deux ans, j’ai travaillé quotidiennement sur ce CRM, en assurant sa stabilité tout en amorçant 
une modernisation progressive de l’ensemble du système.
</p>

<h3 class='mt-4'><strong>Lancement du projet</strong></h3>
<p>
À mon arrivée, l’entreprise souhaitait rendre le CRM plus fiable, plus rapide et plus maintenable, 
tout en préparant une future migration vers des technologies plus modernes. 
Le code était ancien, fortement couplé, parfois sensible à la moindre modification. 
Mon premier travail a donc été de cartographier les flux métier, d’identifier les zones critiques 
et de comprendre les dépendances entre modules WebForms, SQL et Telerik.
</p>
<p>
Cette phase d’observation m’a permis de dégager un objectif clair : 
<strong>stabiliser l’existant tout en améliorant progressivement la performance, la lisibilité du code 
et l’expérience utilisateur interne.</strong>
</p>

<h3 class='mt-4'><strong>Les étapes</strong></h3>
<p>
Mes interventions se sont concentrées sur trois axes principaux : 
</p>

<p>
<strong>1. Stabilisation du code legacy :</strong> correction de comportements inattendus, 
refactorisation de pages WebForms complexes, migration de composants Telerik obsolètes, 
amélioration de la gestion du ViewState et fiabilisation des formulaires.
</p>

<p>
<strong>2. Optimisation des performances :</strong> réduction drastique des temps d’affichage 
sur plusieurs RadGrid lourds, optimisation SQL (index, procédures, vues internes), 
pagination serveur, réécriture de requêtes coûteuses et diagnostic via SQL Profiler.
</p>

<p>
<strong>3. Évolution fonctionnelle :</strong> amélioration de modules clés (KYC, facturation, support), 
mise à jour de flux documentaires, ajout de logs métiers, révision de règles fonctionnelles 
et structuration d’APIs internes pour réduire la dépendance à WebForms.
</p>

<h3 class='mt-4'><strong>Les résultats</strong></h3>

<h4><strong>Pour moi</strong></h4>
<p>
Ce projet m’a donné une expérience complète dans la gestion d’un SI en production, 
avec ses contraintes métiers, ses enjeux de stabilité et ses dépendances historiques. 
J’ai appris à intervenir dans un code legacy volumineux, à anticiper les impacts d’une modification 
et à concilier besoins métier et limitations techniques. 
C’est également ce projet qui m’a ouvert la voie vers des réflexions d’architecture plus modernes 
(.NET Core, GraphQL, séparation des couches, optimisation SQL).
</p>

<h4 class='mt-3'><strong>Pour l’entreprise</strong></h4>
<p>
Les modules critiques sont devenus plus stables, plus rapides et plus robustes. 
Les équipes support et facturation ont gagné en efficacité, les erreurs récurrentes ont été éliminées, 
et les pages stratégiques affichent désormais un temps de réponse nettement amélioré.
La modernisation progressive du CRM a également permis de préparer un futur chantier de migration 
sans perturber les activités quotidiennes.
</p>

<h3 class='mt-4'><strong>Les acteurs</strong></h3>
<p>
Le projet s’est déroulé en étroite collaboration avec :
</p>
<ul>
    <li>les équipes support, pour la gestion des demandes urgentes,</li>
    <li>les utilisateurs métier, pour affiner les règles fonctionnelles,</li>
    <li>le référent CRM, pour garantir la cohérence globale du système,</li>
    <li>les développeurs seniors, pour aligner les choix techniques.</li>
</ul>
<p>
Ces échanges constants m’ont permis de comprendre précisément le fonctionnement du SI 
et d’apporter des améliorations réellement utiles aux utilisateurs.
</p>

<h3 class='mt-4'><strong>Les lendemains du projet</strong></h3>
<p>
Le CRM poursuit sa modernisation. Les prochaines étapes incluent :
</p>
<ul>
    <li>la migration de certains modules vers .NET moderne,</li>
    <li>le remplacement progressif des composants Telerik obsolètes,</li>
    <li>la refonte du modèle SQL,</li>
    <li>la création de nouveaux workflows automatisés pour réduire la charge manuelle,</li>
    <li>l’intégration d’APIs plus structurées, inspirées de GraphQL v2.</li>
</ul>
<p>
Chaque amélioration vise à rendre le système plus performant, plus maintenable 
et plus simple à faire évoluer au fil des besoins métier.
</p>
",
SubProjects = @"
<h3 class='mt-5 mb-3'><strong>Sous-projets associés</strong></h3>

<div class='row row-cols-1 row-cols-md-2 g-4'>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>Module KYC / Conformité réglementaire</h5>
                <p class='card-text'>
                    Stabilisation des flux documentaires (Kbis, RIB, CNI), correction des statuts KYC,
                    amélioration des règles de cohérence, refonte des alertes dans RadGrid, ajout d’un
                    système de traçabilité complet pour audit interne et obligations Tracfin.
                </p>
            </div>
        </div>
    </div>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>Module Facturation & Comptabilité</h5>
                <p class='card-text'>
                    Refonte du calcul automatique, correction d'écarts comptables, stabilisation du workflow
                    de factures groupées, optimisation des exports Excel/PDF, réduction des temps de génération
                    via optimisation SQL (index, procédures, vues internes).
                </p>
            </div>
        </div>
    </div>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>Module Support & Tickets</h5>
                <p class='card-text'>
                    Correction de comportements WebForms/ViewState, optimisation de l’affichage des tickets volumineux,
                    amélioration SLA / priorités, refonte des filtres avancés RadFilter pour éliminer les timeouts SQL.
                </p>
            </div>
        </div>
    </div>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>Optimisation SQL Server</h5>
                <p class='card-text'>
                    Audit SQL via Profiler, ajout d’index stratégiques, refactorisation de stored procedures lourdes,
                    réduction de 30% à 70% des temps de chargement sur plusieurs RadGrid, correction de conflits de collation
                    et conversions implicites.
                </p>
            </div>
        </div>
    </div>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>Modernisation Telerik</h5>
                <p class='card-text'>
                    Migration des composants obsolètes, pagination serveur sur RadGrid, amélioration des RadWindow,
                    correction des RadFilter générant des requêtes SQL invalides.
                </p>
            </div>
        </div>
    </div>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>APIs internes & Migration progressive</h5>
                <p class='card-text'>
                    Structuration d’APIs internes plus robustes, amélioration des endpoints existants,
                    participation à l’évolution vers .NET moderne et une architecture inspirée de GraphQL v2.
                </p>
            </div>
        </div>
    </div>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>Gestion documentaire & Workflows</h5>
                <p class='card-text'>
                    Stabilisation du multi-upload, correction de documents disparaissant au rafraîchissement,
                    amélioration des contrôles de cohérence, fiabilisation du workflow d’archivage.
                </p>
            </div>
        </div>
    </div>

    <div class='col'>
        <div class='card h-100 shadow-sm'>
            <div class='card-body'>
                <h5 class='card-title'>Corrections transverses & Fiabilisation du SI</h5>
                <p class='card-text'>
                    Corrections critiques, nettoyage du modèle SQL (clés orphelines, doublons),
                    stabilisation de modules sensibles utilisés quotidiennement par l’entreprise.
                </p>
            </div>
        </div>
    </div>

</div>
",
            }
        };

        public IEnumerable<Project> GetAll() => _projects;

        public void Add(Project project)
        {
            _projects.Add(project);
        }

        public Project GetById(string id) =>
            _projects.FirstOrDefault(p => p.Id == id);
    }
}

