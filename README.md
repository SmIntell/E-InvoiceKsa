# Watch the full explanation on our YouTube channel.
https://youtu.be/VKuVqWVdQCw

# SmIntell — ZATCA Integration Test App (C#)
Small test project demonstrating how to use ZatcaKsaLib.dll to connect with the Saudi Zakat, Tax and Customs Authority (ZATCA) e-invoicing platform.
Includes a Setup interface for configuring the connection (credentials, environment, certificate) and an Invoice screen to create, sign, and send test invoices.

# Overview
This repository is a compact, hands-on demonstration that shows the typical development flow for integrating an application with ZATCA using the ZatcaKsaLib.dll helper library:
configure the connection and certificate (Setup screen)
create an invoice (Invoice screen)
sign/serialize the invoice using local certificate
submit to ZATCA (sandbox/production toggle)
receive and display the Authority response (success, validation errors)
Purpose: accelerate development and testing by providing a ready UI and code examples you can adapt to your production environment.

# Prerequisites
.NET runtime / SDK compatible with the project (check the project file; recommended: .NET 6 / .NET 7).
Visual Studio (Windows) or Visual Studio for Mac / Rider if the project is cross-platform.
If deployed to a phone: appropriate workload (Xamarin / MAUI) and device set for development (USB debugging enabled on Android / proper provisioning on iOS).
ZatcaKsaLib.dll (the binary you already included) — must be referenced in the project.
Certificate: ZATCA requires invoice signing with a qualified certificate (PFX). Have the PFX file and password ready.
Network access to ZATCA sandbox/production endpoints (or a test proxy).

# Environment (Sandbox vs Production)
Use Sandbox for all early testing.
Switch to Production in the Setup screen only when ready and after confirming certificate/operator readiness.
