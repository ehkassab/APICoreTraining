# API Core Training



## This is to following a full course of web api training.

## MainNotes
	- Appsettings.json is instead of web.config.
	- Launchsettings.json : configure how application will run.
	- dotnet new webapi -n projectName
	- to enable https certs : dotnet dev-certs https --trust
	- remove server ready  actions in launch.json to easy debug
  	- add group in tasks.json to easy buildCommit Testing
	- Dependency Inversion principle: is that class should depend on interface instead of class.
	- Dependency Injection 
	- Dotnet add package MongoDB.Driver
	- Container is an instance of Image
	- .net Secret Manager
	- Configuration Services can be used by 
		- Appsettings.json
		- CLI
		- Environment Variables
		- Cloud sources
		- Secret manager. Dotnet user-secrets init
		- Create default builder is taking care of inject secret manger automatically.
		- dotnet user-secrets set MongoPassword:Password P@wer2342

		
## Main Course URL 

<a href="https://www.youtube.com/watch?v=ZXdFisA_hOY&t=22123s" target="_blank"> <img src="https://www.vectorlogo.zone/logos/youtube/youtube-icon.svg" alt="postman" width="40" height="40"/> </a>
