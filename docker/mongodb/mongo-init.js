db.createUser(
    {
        user: "beat",
        pwd: "password",
        roles: [
            {
                role: "readWrite",
                db: "ecoprove"
            }
        ]
    }
);

db.createCollection("notifications");