# Manager Logistique : exchange to have transport details [![Official Site](https://img.shields.io/badge/site-servodroid.com-orange.svg)](http://servodroid.com)

[![Version Status](https://img.shields.io/nuget/v/Droid_Logistique.svg)](https://www.nuget.org/packages/Droid_Logistique/)    [![License](https://img.shields.io/github/license/brandondahler/Data.HashFunction.svg)](https://raw.githubusercontent.com/ThibaultMontaufray/Tools4Libraries/master/License) [![Build Status](https://travis-ci.org/ThibaultMontaufray/Manager-Logistique.svg?branch=master)](https://travis-ci.org/ThibaultMontaufray/Manager-Logistique) [![Coverage Status](https://coveralls.io/repos/github/ThibaultMontaufray/Manager-Logistique/badge.svg?branch=master)](https://coveralls.io/github/ThibaultMontaufray/Manager-Logistique?branch=master)  [![Jenkins test](https://img.shields.io/jenkins/t/http/servodroid.com:8080/CI-Manager-Logistique.svg)](http://servodroid.com:8080/job/CI-Manager-Logistique/)  [![Code Climate](https://codeclimate.com/github/ThibaultMontaufray/Manager-Logistique/badges/gpa.svg)](https://codeclimate.com/github/ThibaultMontaufray/Manager-Logistique)

# Usage :

Set the token in Controler/Queries.cs or set it in the config file
```csharp
public const string TOKEN = "azertyuiopmlkjhgfdsqwxcvbn.125.458.679.254";
```
and run the demo
```csharp
Application.Run(new Demo());
```

# Demo

Arrivals from a station
<p><img src="demo1.png" /></p>

Departure from a station
<p><img src="demo2.png" /></p>

Station details
<p><img src="demo3.png" /></p>

Looking for a journey
<p><img src="demo4.png" /></p>
