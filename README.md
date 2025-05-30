﻿The Puma Programming Language Project

The goal of this project is to write an LLVM compiler front-end for the Puma Programming Language. Puma is a new programming language that is safe, organized, maintainable, readable, reliable and efficient.

Goals:
The current goal of this project is to write a compiler front-end for the Puma Programming Language in three phases.

Phase A:
Write a Puma to C/C++ translator that calls the clang compiler to finished building the application. This translator does not have to be fast at building the app but the executable should be approximately as fast as C/C++.

Phase B:
Refactor the Phase A compiler by replacing the current language code with the Puma Programming Language itself.  At the end of this phase, the Puma compiler shall be able to build itself.  This compiler should be faster at building Puma apps than the Phase A compiler and the executables shall be as fast.

Phase C:
Refactor the Phase A compiler to translate to the LLVM Intermediate language instead of C/C++.  The LLVM backend will finish the build.  This compiler should be faster at building Puma apps compared to Phase B.  The clang compiler will be used to learn how to write efficient Intermedeate language code.  

Standard Library:
Write a standard library that is convenient and easy to use.  Advance features may be added but defaults must keep the components of the library convenient and easy to use.

Documents:
The specification and code of conduct documents are found in the doc folder.  


