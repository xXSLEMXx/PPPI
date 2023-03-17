from item import Item


class Armor(Item):
    def __init__(self, name, sprite, defence):
        self.defence = defence
        super(Armor, self).__init__(name, sprite)
        
         
    def __str__(self):
        pass
