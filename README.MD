# Meat Department Field Guide

## Overview

**Meat Department Field Guide** is a cross-platform quick-reference, knowledge, and training platform for meat cutting, fabrication, equipment, and related culinary knowledge.

The project begins with **beef** because beef fabrication is complex and provides a strong first domain. The architecture is intentionally designed so the same underlying knowledge can eventually be presented through:

- Mobile/desktop application
- Browser-based Web UI
- LMS-compatible training packages, including SCORM
- Future enterprise integrations and APIs

The goal is **one structured knowledge platform with multiple presentation clients**, not three unrelated products.

> **Put the right information in front of the right person at the moment they need it.**

---

# Product Vision

```text
                 MEAT KNOWLEDGE PLATFORM
                          |
             +------------+------------+
             |            |            |
          REFERENCE     TRAINING    ENTERPRISE
             |            |            |
          Mobile        SCORM         LMS
          Web UI        Courses       Integration
          Desktop       Assessments   Reporting
```

The knowledge layer is the common foundation. Presentation can change without rewriting the underlying meat knowledge.

---

# Primary Users

The project intentionally targets both individuals and organizations.

## 1. Enterprise / Workforce Training

Large organizations are a major long-term target.

Potential customers include:

- Grocery and warehouse retailers
- Hotels and hospitality organizations
- Restaurants and food-service organizations
- Culinary schools
- Food-production companies
- Meat-processing organizations
- Companies with large frontline workforces

Examples of the type of organization this could eventually interest include **Costco, Hilton, and similar large employers**.

Potential enterprise capabilities:

- Standardized reference material
- Supplemental employee training
- Searchable procedures
- Equipment information
- Knowledge checks
- Assessments
- Progress/completion tracking
- Company-specific content
- Department-specific procedures
- LMS integration
- SCORM course packages
- Future API integrations

Company-specific information should remain separate from the neutral core knowledge base.

```text
Company
  |
  +-- Training
  |     +-- Beef Cutting Fundamentals
  |     +-- Equipment Safety
  |     +-- Department Procedures
  |
  +-- Reference
  |     +-- Approved Cuts
  |     +-- Approved Equipment
  |     +-- Internal Procedures
  |
  +-- Employees
        +-- Progress
        +-- Assessments
```

The initial application does not need all of this. The architecture must simply leave room for it.

---

## 2. Apprentice / New Meat Cutter

A new cutter is learning beef anatomy, primals, subprimals, cut names, knife selection, trimming, fabrication, portioning, packaging, equipment operation, and department terminology.

The Field Guide acts as a **pocket reference and supplemental training aid**. It does not replace formal training, supervision, workplace safety rules, or manufacturer instructions.

---

## 3. Journeyman / Experienced Meat Cutter

Experience does not eliminate the need for reference information.

An experienced cutter may need to verify an unfamiliar cut, regional terminology, an IMPS specification, a fabrication procedure, knife selection, available cuts, or an equipment error code.

The application should remain useful to someone with years of experience.

---

## 4. Department Manager / Lead

Managers and leads may use the system to:

- Answer employee questions
- Review procedures
- Look up equipment information
- Provide supplemental training
- Maintain department-specific references
- Record approved equipment information
- Support onboarding

---

## 5. Culinary Instructor / Trainer

Instructors can use the Field Guide as a supplemental resource for primal identification, cut relationships, knife selection, fabrication, terminology, visual references, and training exercises.

---

## 6. Aspiring Chef / Culinary Student

The Field Guide can bridge classroom instruction and hands-on practice through meat anatomy, primal/subprimal relationships, terminology, cutting procedures, knife selection, alternative names, and visual references.

---

## 7. Serious Home Butcher / Hunter

Potential users include hunters, homesteaders, small-scale livestock owners, serious home butchers, and meat-processing hobbyists.

---

## 8. Meat Smoker / BBQ Enthusiast

A user may follow:

```text
Primal → Subprimal → Cut → Trim → Preparation → Cooking Resources
```

The Field Guide does not need to become a recipe application to be useful to this audience.

---

## 9. Backyard Grill Enthusiast

A home cook can search an unfamiliar cut and learn what it is, where it comes from, alternate names, characteristics, trimming, preparation methods, related cuts, and cooking approaches.

---

# Core Knowledge Architecture

```text
Meat
 └── Region
      └── Primal
           └── Subprimal
                └── Cut
                     ├── Procedures
                     ├── Knife Suitability
                     ├── Images
                     ├── Resources
                     ├── FAQs
                     └── Related Cuts
```

The first release focuses heavily on beef, while the architecture supports:

```text
Beef
Pork
Lamb
Mutton
Veal
Goat
Poultry
Game
```

Adding another species should primarily involve adding content rather than rewriting UI code.

---

# Reference and Training Are Different Things

Reference content answers questions such as:

- What is this cut?
- Where does it come from?
- Which knife is appropriate?
- How is it produced?
- What does this error code mean?

Training content can turn the same knowledge into:

```text
Lesson
  ↓
Instruction
  ↓
Demonstration
  ↓
Knowledge Check
  ↓
Assessment
  ↓
Completion
```

This distinction lets the product remain a useful field reference while also becoming a formal training product.

---

# Mobile, Web, and SCORM

## Mobile / Desktop

The installed application can provide offline reference material, SQLite/local data, camera access, local images, personal knives, device capabilities, and native packaging.

The planned .NET direction is **.NET MAUI with a web-oriented UI approach such as Blazor Hybrid**, allowing substantial UI reuse.

## Web UI

A browser client provides no-install access, shared/current content, larger-screen workflows, administration possibilities, and broad device access.

A browser cannot simply open the native SQLite file used by an installed application. The Web client therefore needs an appropriate Web data layer rather than directly depending on the local mobile database.

## SCORM

SCORM is treated as a **training delivery format**, not the core architecture.

A SCORM package can present selected Field Guide knowledge as an LMS course and report progress, completion, assessment results, and pass/fail status.

The core knowledge system remains independent of SCORM. Future LMS integrations may also consider standards such as xAPI/cmi5 where appropriate.

---

# Intended Platform Architecture

```text
                         CORE DOMAIN
                             |
                     APPLICATION SERVICES
                             |
                +------------+-------------+
                |            |             |
             Mobile        Web          Training
             Client        Client         Client
                |            |             |
           MAUI/Blazor    Browser       SCORM
                |            |             |
                +------------+-------------+
                             |
                     Shared APIs/Services
                             |
                    Knowledge/Data Layer
                             |
                    Local / Server Data
```

---

# Core User Experience

> **Start with what the user has, then help them discover what they need.**

```text
Beef
  ↓
Region
  ↓
Primal
  ↓
Subprimal
  ↓
Cut
  ↓
What can I do with it?

  Identify
  Fabricate
  Trim
  Portion
  Cook / Prepare
  Recommended Knives
  Images
  FAQs
  External Resources
```

Search provides another path:

```text
Search → "cimeter" → Knife Type → Cuts / Procedures
```

---

# Knife Personalization

Users can maintain their own knife inventory with custom name, manufacturer, model, blade length, steel, knife type, notes, and local photograph.

User-owned knives always receive priority when showing suitable tools.

```text
RECOMMENDED

YOUR KNIVES
  ✓ The Little Bastard — Boning Knife
  ✓ Big Red — Cimeter

SUGGESTED
  Breaking Knife
```

Commercial recommendations must remain neutral and separate from factual suitability.

---

# Primal Identification

Future workflow:

```text
Take Photo
    ↓
Local Reference Matching
    ↓
Candidate Match
    ↓
User Confirmation
   /  OK  Try Again
```

If local identification fails, an external service may optionally be used with appropriate consent.

Privacy requirements include local processing when practical, clear explanation when images leave the device, appropriate permissions, no silent uploads, and clear distinction between local and external results.

---

# Equipment Troubleshooting

A major workplace use case is:

> **The equipment broke, the manager isn't here, and nobody remembers what the error means.**

```text
Equipment
  ↓
Manufacturer
  ↓
Model
  ↓
Problem / Error Code
  ↓
Operator Checks
  ↓
Possible Causes
  ↓
Safe Corrective Action
  ↓
STOP / CALL AUTHORIZED SERVICE
```

Information should distinguish operator checks, cleaning/setup issues, consumables, configuration, qualified maintenance, and stop-operation conditions.

---

# Commercial Boundaries

The Field Guide is **knowledge-first, not sales-first**.

Factual suitability must never change because a manufacturer or retailer sponsors the application.

Potential future sponsorship:

```text
Factual Recommendation
        ↓
Optional Sponsored Information
        ↓
Optional External Search
```

A sponsor cannot purchase a higher factual suitability ranking.

---

# Development Strategy

## Phase 1 — Stabilize the Foundation

1. Standardize SQLite implementation
2. Establish one authoritative database path/connection system
3. Finish migrations
4. Replace/fix database seeding
5. Finish repositories
6. Finish application services
7. Add integration tests
8. Verify the first complete data path

Target:

```text
Beef
 → Region
 → Primal
 → Subprimal
 → Cut
 → Procedure
 → Knife Suitability
 → User Knives
 → Recommendation
```

## Phase 2 — Platform Foundation

Add structured content, training, search/FTS5, media, external resources, favorites, settings, progress/completion, caching, and logging.

## Phase 3 — Clients

Build:

1. Mobile/desktop application
2. Web UI
3. SCORM training package

The goal is to release these as parts of the same product rather than unrelated projects.

## Phase 4 — Enterprise

Add when the core product is proven:

- Organizations/tenants
- Company-specific content
- Roles and permissions
- Administration
- Course authoring
- Employee enrollment
- Progress reporting
- Assessments
- LMS integration
- API access
- Enterprise deployment options

---

# Technical Direction

The project favors:

- C#
- Modern .NET
- .NET MAUI
- Blazor/web UI where it provides real reuse
- SQLite for local/offline storage
- A suitable server database for shared Web/enterprise deployments
- Dependency injection
- Repository/service separation where appropriate
- Async programming
- Cancellation support
- Caching
- Full-text search
- Database migrations
- Automated testing
- Clear separation of concerns

The project deliberately avoids architectural complexity that does not solve a real problem.

> **If future-you has to debug it at 2 AM, future-you should understand it.**

---

# Planned Solution Structure

```text
MeatDepartmentFieldGuide.sln
│
├── MeatDepartmentFieldGuide.Core
│   ├── Entities
│   ├── DTOs
│   ├── Interfaces
│   └── Enums
│
├── MeatDepartmentFieldGuide.Application
│   ├── Services
│   ├── Search
│   ├── Identification
│   └── Recommendations
│
├── MeatDepartmentFieldGuide.Infrastructure
│   ├── SQLite
│   ├── Repositories
│   ├── Cache
│   ├── ExternalProviders
│   └── Media
│
├── MeatDepartmentFieldGuide.App
│   ├── Views
│   ├── ViewModels
│   ├── Resources
│   └── Platforms
│
└── MeatDepartmentFieldGuide.Tests
```

Web and SCORM clients can be added as separate presentation projects while keeping domain/application logic shared.

---

# Engineering Principles

1. Knowledge is separate from presentation.
2. Reference content is separate from training delivery.
3. The database is a core product component.
4. No SQL belongs in ViewModels.
5. Relationships should be explicit and understandable.
6. Use abstractions when they solve a real problem.
7. Prefer maintainability over architectural decoration.
8. Core functionality should work offline when practical.
9. Privacy should be designed in rather than added later.
10. Sponsorship must not compromise factual neutrality.
11. Enterprise functionality should extend the product rather than distort the basic user experience.
12. The same knowledge should be reusable across mobile, Web, and training experiences.

---

# Release Vision

The intention is to release the Field Guide as a coordinated product rather than releasing an isolated mobile application and retrofitting the enterprise/training system later.

The first public version can still be focused:

```text
BEEF
  + Knives
  + Procedures
  + Search
  + Equipment
```

while the architecture supports:

```text
                FIELD GUIDE
                    |
        +-----------+-----------+
        |           |           |
      MOBILE       WEB        SCORM
        |           |           |
        +-----------+-----------+
                    |
             KNOWLEDGE PLATFORM
                    |
             ENTERPRISE READY
```

The first release does not need every enterprise feature. It does need to avoid architectural decisions that would make those features unnecessarily expensive later.

---

# Current Project Status

The immediate priority is to get the existing database/backend foundation into a clean, buildable state **before beginning the new front-end clients**.

```text
Existing Code
    ↓
Fix SQLite Architecture
    ↓
Fix Migrations
    ↓
Fix Seeder
    ↓
Finish Repositories
    ↓
Finish Services
    ↓
Automated Tests
    ↓
Successful Build
    ↓
Mobile/Web UI Foundation
    ↓
SCORM Foundation
```

The next development step is therefore **not more UI**. It is cleaning the existing source so we have a trustworthy buildable foundation.

---

# Guiding Principle

> **Put the right information in front of the right person at the moment they need it.**

Whether that person is a new meat cutter at a cutting table, an experienced employee troubleshooting equipment, a culinary student, a homeowner preparing dinner, or an enterprise employee completing required training, the goal is the same:

**Make useful knowledge easier to find, understand, and use.**
