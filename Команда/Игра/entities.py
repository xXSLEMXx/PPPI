class Entity:
    def __init__(self, health_point, damage, sprite, defence,
                 drop, iframe=0.1):
        self.health_point = health_point
        self.damage = damage
        self.sprite = sprite
        self.defence = defence
        self.drop = drop
        self.iframe = iframe

    def die(self):
        pass

    def spawn(self):
        pass

    def draw(self):
        pass


class Mob(Entity):
    def attack_player(self):
        pass


class NPC(Entity):
    def speak(self):
        pass
        
             
    def __str__(self):
        pass
