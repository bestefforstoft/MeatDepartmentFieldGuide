##
## THIS IS THE BASE CODE SO FAR AND DOES CONTAIN ERRORS AND IS NOT COMPLETE
##           THE BASIC CONCEPT IS DESCRIBED BELOW
##
=============================================================================
# Meat Department Field Guide

## Overview

**Meat Department Field Guide** is a cross-platform quick-reference and knowledge application designed to put practical meat-cutting information in one place.

The idea came from a simple problem: people working with meat often need an answer **right now**. A new meat cutter may need to identify a primal or remember how a particular cut is produced. An experienced cutter may know the answer but occasionally need to verify a specification, terminology, knife choice, or procedure. A backyard griller may have purchased a cut they do not recognize and want to know what it is and how to prepare it.

Today, that information is often scattered across:

- YouTube videos
- Search engines
- Training documents
- Printed references
- Equipment manuals
- USDA/industry documentation
- Personal experience
- Coworkers who may simply say "look it up on YouTube"

The **Meat Department Field Guide** is intended to provide a structured, searchable, practical reference that can grow from a beef-focused guide into a broader meat-processing and culinary knowledge system.

---

## The Need This App Fills

The application addresses a gap between **formal training/reference material** and **real-world, at-the-workbench information**.

Traditional training can teach someone the fundamentals, but people forget details. Experienced workers encounter unfamiliar cuts, unusual situations, equipment problems, or terminology differences. Hobbyists and aspiring cooks face the opposite problem: they may have access to excellent ingredients but lack the knowledge to identify, cut, trim, or prepare them.

The Field Guide brings related information together around the thing the user is actually working with.

For example:

> **I have this piece of beef. What is it? Where did it come from? What cuts can I make from it? Which knife should I use? How do I make the cut? What are the alternatives?**

The application should be able to progressively answer those questions without forcing the user to search several unrelated sources.

---

# Primary Users

The application is intentionally broader than a training tool for grocery-store employees.

## 1. Apprentice / New Meat Cutter

### Problem

A new meat cutter is learning a large amount of information at once:

- Beef anatomy
- Primals and subprimals
- Cut names
- Alternative names
- Knife selection
- Trimming techniques
- Cutting procedures
- Portioning
- Packaging
- Equipment operation
- Department terminology

It is unrealistic to expect someone to remember everything immediately.

### Use Case

A new cutter is given an unfamiliar piece of beef.

They can:

1. Select **Beef**
2. Navigate to the appropriate region
3. Identify the primal
4. Select the subprimal
5. Select the desired cut
6. Review the cutting procedure
7. See recommended knife types
8. See which of their own knives are appropriate
9. Review images and reference material
10. Watch an associated instructional video if one is available

The Field Guide acts as a **pocket reference and supplemental training aid**.

It does not replace formal training, supervision, workplace safety rules, or manufacturer instructions.

---

# 2. Journeyman / Experienced Meat Cutter

### Problem

Experience does not eliminate the need for reference information.

An experienced cutter may encounter:

- A cut they have not produced recently
- Regional terminology differences
- A different specification
- An unfamiliar subprimal
- A less-common fabrication procedure
- A new piece of equipment
- An equipment error code
- A question from a newer employee

### Use Case

A journeyman cutter can quickly search for:

> "What is the IMPS number for this?"

> "What cuts come from this subprimal?"

> "Which knife is normally used for this?"

> "What is this cut called?"

> "How do I break this down?"

> "What does this wrapper error mean?"

The application should therefore be useful even to someone who already has years of experience.

---

# 3. Backyard Grill Enthusiast

### Problem

Home cooks often purchase meat without knowing exactly what they have or how best to use it.

A person may encounter an unfamiliar cut at a grocery store, butcher shop, farmers market, or warehouse retailer.

### Use Case

The user can:

- Search for a cut
- Learn where it comes from
- See alternate names
- Understand its characteristics
- Learn appropriate preparation methods
- Explore trimming information
- Find related cuts
- Review recommended cooking approaches

Example:

> "I bought a tri-tip. What exactly is it, where does it come from, and what should I do with it?"

The Field Guide can provide the meat-processing context while optionally connecting the user to cooking resources.

---

# 4. Meat Smoker / BBQ Enthusiast

Smoking and barbecue involve a particularly strong relationship between **cut identification, trimming, preparation, and cooking**.

### Use Cases

A smoker may want to know:

- What cut they have
- How it relates to the primal
- How much exterior fat to remove
- Which seams should be separated
- Whether the cut is better suited to smoking, roasting, grilling, braising, etc.
- What other cuts can be obtained from the same subprimal
- What terminology different regions use

The application can eventually provide a path such as:

**Primal → Subprimal → Cut → Trim → Preparation → Cooking Resources**

The Field Guide does not need to become a recipe application to be valuable to barbecue enthusiasts.

---

# 5. Aspiring Chef / Culinary Student

### Problem

Culinary students learn both cooking and ingredient knowledge, but meat fabrication can be a specialized subject.

The application can serve as a reference between classroom instruction and hands-on practice.

### Use Cases

A culinary student can:

- Study meat anatomy
- Learn primal/subprimal relationships
- Learn professional terminology
- Review cutting procedures
- Study knife selection
- Compare cuts
- Learn alternative names
- Review reference material
- Use images as visual study aids

This makes the application useful as a **culinary reference tool**, not merely a grocery-store employee application.

---

# 6. Serious Home Butcher / Hunter

Another potential audience is people who process their own meat.

Examples include:

- Hunters
- Small-scale livestock owners
- Homesteaders
- Serious home butchers
- Meat-processing hobbyists

Their needs overlap heavily with professional meat cutting:

- Identification
- Anatomy
- Fabrication
- Knife selection
- Trimming
- Portioning
- Preservation
- Terminology

Future versions could expand beyond beef into species commonly processed by these users.

---

# 7. Culinary Instructor / Trainer

The Field Guide can also function as a supplemental teaching resource.

An instructor could use it to demonstrate:

- Primal identification
- Cut relationships
- Knife selection
- Fabrication procedures
- Terminology
- Visual references

Because the information is structured in a database rather than hard-coded into individual screens, educational content can grow independently of the UI.

---

# 8. Department Manager / Lead

A department manager may use the application differently from an apprentice.

Potential uses include:

- Quickly answering employee questions
- Looking up equipment information
- Reviewing procedures
- Providing supplemental training
- Creating department-specific reference material
- Recording approved equipment information
- Maintaining internal notes

A future version could support controlled department/company-specific content without changing the fundamental architecture.

---

# Core User Experience

The application should generally follow a simple principle:

> **Start with what the user has, then help them discover what they need.**

For example:

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
  ├── Identify
  ├── Fabricate
  ├── Trim
  ├── Portion
  ├── Cook / Prepare
  ├── Recommended Knives
  ├── Images
  ├── FAQs
  └── External Resources
```

Search should provide another path:

```text
Search
  ↓
"cimeter"
  ↓
Knife Type
  ↓
Cuts / Procedures
```

Or:

```text
Search
  ↓
"bottom round"
  ↓
Cut
  ↓
Parent Subprimal
  ↓
Parent Primal
  ↓
Related Procedures
```

---

# Knife Personalization

One of the Field Guide's distinguishing features is that knife information is not limited to a static list.

A user can maintain a personal knife inventory.

For example:

```text
My Knives

├── "The Excalibur"
│   ├── Breaking Knife
│   ├── German steel
│   └── 10 inch
│
├── "The Little Bastard"
│   ├── Boning Knife
│   └── 6 inch
│
└── "Big Red"
    └── Cimeter
```

The user can:

- Photograph their knives
- Give them custom names
- Record manufacturer/model
- Record blade length
- Record steel
- Add notes
- Associate a knife with a knife type

When viewing a procedure, the application can prioritize the user's own suitable knives.

Example:

```text
Recommended for this cut

YOUR KNIVES
✓ The Little Bastard
  Boning Knife

✓ Big Red
  Cimeter

SUGGESTED
Breaking Knife
```

After a user has seen the suggestion several times, the application can reduce repetitive information and show a compact suggestion instead.

This keeps the interface useful rather than cluttered.

---

# Primal Identification

A future feature will allow the user to photograph a piece of meat and attempt identification.

The intended process is:

```text
Take Photo
    ↓
Local Reference Matching
    ↓
Candidate Match
    ↓
User Confirmation
   / \
 OK   Try Again
```

If local identification is unsuccessful, the application may optionally use an external identification service.

Privacy is important here.

The application should:

- Clearly explain when an image leaves the device
- Request appropriate permission/consent
- Prefer local processing when practical
- Avoid silently uploading user photographs
- Clearly distinguish local results from external results

---

# Equipment Troubleshooting

The Field Guide is also intended to address a common workplace problem:

> **The equipment broke, the manager isn't here, and nobody remembers what the error means.**

Automated wrappers are an initial target.

A troubleshooting entry may contain:

```text
Equipment
    ↓
Manufacturer
    ↓
Model
    ↓
Problem / Error Code
    ↓
What the operator can check
    ↓
Possible causes
    ↓
Safe corrective action
    ↓
STOP / CALL AUTHORIZED SERVICE
```

The system should distinguish between:

- Operator-level checks
- Cleaning/setup issues
- Consumable/material issues
- Configuration issues
- Maintenance requiring qualified personnel
- Conditions where operation should stop

Equipment information should be based on appropriate manuals and authoritative documentation.

---

# Knowledge Architecture

The application is designed around a structured knowledge hierarchy rather than individual hard-coded pages.

At its core:

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

This architecture allows additional species to be added without redesigning the application.

For example:

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

The first release will focus heavily on beef.

---

# Design Goals

## Practical

The application should answer real questions quickly.

## Searchable

Users should not need to know the exact terminology before finding useful information.

## Visual

Meat identification and fabrication are highly visual subjects.

## Extensible

Adding another species should primarily involve adding content rather than rewriting the application.

## Offline-Friendly

Core reference material should remain available without an Internet connection whenever practical.

## Privacy-Conscious

Local data should remain local unless the user explicitly chooses functionality requiring external services.

## Non-Commercial by Default

The application should not feel like a shopping application.

Future sponsorship opportunities may exist, particularly with knife manufacturers or meat-industry businesses, but sponsorship should remain separate from factual recommendations.

## Technically Sound

The project is intended to demonstrate professional software engineering practices:

- .NET MAUI
- C#
- SQLite
- Dependency Injection
- Repository patterns where appropriate
- Service-oriented application logic
- Async programming
- Cancellation support
- Caching
- Full-text search
- Testable architecture
- Database migrations
- Structured domain models
- Clear separation of concerns

The project should favor maintainability and clarity over unnecessary architectural complexity.

---

# Example User Scenarios

## "I'm new and don't know what this is."

**Photo / Search → Candidate Primal → Confirm → Learn**

---

## "I've cut this before, but I haven't done it in six months."

**Search → Cut → Procedure → Review**

---

## "Which knife should I use?"

**Cut → Recommended Knives → My Knives → Select Knife**

---

## "I only have these three knives."

**My Knives → Knife Type → Compatible Cuts**

---

## "What can I make from this?"

**Primal → Subprimal → Available Cuts**

---

## "What is this cut called?"

**Search / Identification → Cut → Alternate Names**

---

## "I bought this at Costco and have no idea what it is."

**Search / Photo → Identification → Cut Information → Preparation Resources**

---

## "My wrapper is throwing an error."

**Equipment → Wrapper → Model → Error Code → Troubleshooting**

---

## "I'm studying for culinary school."

**Beef → Region → Primal → Subprimal → Cut → Study**

---

## "I'm smoking brisket this weekend."

**Brisket → Anatomy → Trim → Preparation → Cooking Resources**

---

# Long-Term Vision

The long-term goal is not simply to create an electronic butcher's handbook.

The goal is to create a **structured meat knowledge platform** that connects:

```text
IDENTIFICATION
      ↓
ANATOMY
      ↓
FABRICATION
      ↓
KNIFE SELECTION
      ↓
PROCEDURE
      ↓
PREPARATION
      ↓
COOKING
```

while remaining useful at multiple levels of expertise.

A new employee should be able to use it.

A journeyman should still find it useful.

A backyard smoker should understand it.

A culinary student should learn from it.

An experienced home butcher should be able to reference it.

That range of users is intentional.

---

# Project Status

The initial development strategy is:

1. Establish the domain model
2. Build the SQLite database
3. Implement migrations
4. Seed the initial beef knowledge
5. Implement repositories
6. Implement application services
7. Build automated tests
8. Create the first MAUI vertical slice
9. Implement search
10. Implement knife personalization
11. Implement media/resources
12. Implement equipment troubleshooting
13. Implement image identification
14. Expand to additional species

The first major milestone is:

> **Beef → Region → Primal → Subprimal → Cut → Procedure → Knife Suitability → User Knives**

Once that complete path works, the application has a functional foundation on which the remaining features can be built.

---

# Why This Project Matters

The Field Guide is both a practical application and a software engineering project.

Its value comes from solving a real-world information problem while providing an opportunity to demonstrate:

- Domain modeling
- Relational database design
- Cross-platform application development
- Search architecture
- Offline-first thinking
- Media management
- Personalization
- External service integration
- Testing
- Maintainable architecture

Most importantly, the application should be useful enough that someone can actually reach for it when they need an answer.

---

## Guiding Principle

> **Put the right information in front of the right person at the moment they need it.**

The application should make that happen without making the user fight the interface.
