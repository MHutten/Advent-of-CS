https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/
Every option follows the following pattern:
(/|-)<option>:<arguments>
where arguments are separated by ';' (QUESTION: Is separation by ';' true for every option with arguments?)

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/language:
checked
unsafe
define
langversion
nullable

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/output:
doc
out
platform
refout
t[arget]

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/inputs:
r[eference]
addmodule
link

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/errors-warnings:
warn
/ (QUESTION: The table on the website shows "/" alongside "-warn". Is this option specified with "//" and "-/", or simply "/"?)
warnaserror
warnaserror+
warnaserror-
nowarn
ruleset
errorlog
reportanalyzer

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/code-generation:
debug
optimize
deterministic
refonly

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/security:
publicsign
delaysign
keyfile
keycontainer
highentropyva

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/resources:
win32res
win32icon
win32manifest
nowin32manifest
res[ource] (QUESTION: The website only mentiones "/res" as a short form, does "-res" also work?)
linkresources

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/miscellaneous:
@CustomOpts.RSP (QUESTION: This option is shown alongside "-nologo". Is the option specified with "/@CustomOpts.RSP" and "-@CustomOpts.RSP", or simply "@CustomOpts.RSP"?)
nologo
noconfig