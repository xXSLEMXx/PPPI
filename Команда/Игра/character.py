from inventory import Inventory
from armor import Armor
from accessory import Accessory


class Character:
    def __init__(self, health_point, mana_point, inventory: Inventory,
                 armor: list[Armor], accessories: list[Accessory], iframe=0.1):
        self.health_point = health_point
        self.mana_point = mana_point
        self.iframe = iframe

        self.inventory = inventory
        self.defence = 0
        self.armor = armor
        self.accessories = accessories

    def left_click(self):
        pass

    def right_click(self):
        pass

    def move(self):
        pass

    def interact_with_inventory(self):
        pass

    def craft(self):
        pass

    @classmethod
    def load(cls, data):
        pass
        
             
    def __str__(self):
        pass
