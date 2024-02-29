db.createUser(
    {
        user: process.env.MONGO_DEFAULT_USER,
        pwd: process.env.MONGO_DEFAULT_PASSWORD,
        roles: [
            {
                role: "readWrite",
                db: process.env.MONGO_INITDB_DATABASE,
            }
        ]
    }
);

db.createCollection("notifications");
db.createCollection("messages");