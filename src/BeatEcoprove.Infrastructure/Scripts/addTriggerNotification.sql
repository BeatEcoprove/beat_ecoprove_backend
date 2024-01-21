CREATE OR REPLACE FUNCTION update_xp_trigger_function()
RETURNS TRIGGER AS $$
DECLARE
    level_up_data json;
BEGIN
    IF NEW.level IS DISTINCT FROM OLD.level THEN
        select 
            json_build_object(
                'id', NEW."Id",
                'level', NEW.level,
                'xp', NEW.xp
            )
        from profiles
        where "Id" = NEW."Id"
        into level_up_data;
        
        PERFORM pg_notify('level_up', level_up_data::text);
END IF;
RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER update_xp_trigger
    AFTER UPDATE ON profiles
    FOR EACH ROW
    EXECUTE FUNCTION update_xp_trigger_function();
