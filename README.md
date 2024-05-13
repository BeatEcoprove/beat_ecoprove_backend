# 🎉 Welcome to the **Beat Ecoprove** Installation Fiesta! 🎉

Ready to dive to setup the backend component of ``Ecoprove``? Let’s get this party started with some seriously smooth installation moves. Follow these simple steps, and you’ll be dancing through your codebase in no time!

### Step 1: Git Groove

🚀 Fire up your terminal and get ready to bust out some Git magic. Type in this cool command:

```bash
git clone 
```

Whoosh! You’ve just cloned your repository like a pro! 💪 Now, let’s move on to the next step and add some flavor to your project.

### Step 2: Mix & Match with Environment Variables

Now it’s time to give your project some spice by configuring those environment variables. Navigate to your project directory and do a little file renaming dance:

```bash
mv .env.example .env
```

```env
NGINX_HTTP_PORT=80

# Environment variables for the mongo
MONGO_INITDB_ROOT_USERNAME=user
MONGO_INITDB_ROOT_PASSWORD=verysecurepassword
MONGO_DEFAULT_USER=beat
MONGO_DEFAULT_PASSWORD=verysecurepassword
MONGO_INITDB_DATABASE=ecoprove
MONGO_PORT=27017
MONGO_HOST=localhost

# Environment variables for the redis
REDIS_HOST=localhost
REDIS_PORT=6379
REDIS_PORT_INTERFACE=8001

# Environment variables for the postgres
POSTGRES_DB=ecoprove
POSTGRES_USER=user
POSTGRES_PASSWORD=verysecurepassword
POSTGRES_PORT=5432
POSTGRES_HOST=localhost

# Environment variables for the beat backend
BEAT_API_REST_PORT=5182

# Environment variables for the ASP.NET Core backend
ASPNETCORE_HTTP_PORTS=5182
ASPNETCORE_URLS=http://*:80

# Environment variables for the jwt token
JWT_SECRET_KEY=4ABA18D711391CB47A2152940E6554E7F80245D00BDA085F98FD5BE24E51BA42
JWT_ISSUER=BeatEcoprove
JWT_AUDIENCE=Beat Ecoprove
JWT_ACCESS_TOKEN_EXPIRATION=1
JWT_REFRESH_TOKEN_EXPIRATION=2

# Environment variables for the email
SMTP_HOST_EMAIL=no-replay@beat-ecoprove.pt
SMTP_HOST=sandbox.smtp.mailtrap.io
SMTP_PORT=25
SMTP_HOST_USER=<smtp-user>
SMTP_HOST_PASSWORD=<smtp-password>
```

Now, open up that freshly minted .env file and fill it up with the secret sauce your project needs. Think of it as adding the toppings to your pizza – it’s what makes it uniquely yours! 🍕


### Step 3: Docker Disco

Time to take your project to the next level with Docker Compose! Get ready to spin up your containers like a DJ at a rave. 🎧

But first, make sure you're in the groove by navigating to your project directory. Once you're there, it's showtime! Execute this electrifying command:

```bash
docker-compose --profile dev up
```

Watch as your project comes to life, each container syncing perfectly with the others like dancers in perfect harmony. 🕺💃

Now, take a moment to revel in the beauty of your creation. Your project is now running smoothly, thanks to Docker Compose!

Keep the momentum going, and remember, you're not just coding, you're orchestrating a symphony of technology. Stay tuned for more steps in your **Beat Ecoprove** installation adventure! 🚀✨

### Step 5: Swagger

Time to rock your stuff with Swagger! Your backend is up and running, and now it's time to explore its swagger.

Open up your favorite web browser and head over to:

```
http://localhost/swagger
```

Boom! You're now face-to-face with your backend's swagger documentation. It's like your project just rolled out the red carpet for you! 🎩✨

Swagger makes it easy to interact with your API, explore endpoints, and even test out requests right from your browser. So go ahead, take it for a spin, and see the magic of your backend in action!

Your project is up, running, and ready to serve the circular market of cloth. Keep on using and providing for it, and never stop reaching for the stars! 🌱👕"🌟