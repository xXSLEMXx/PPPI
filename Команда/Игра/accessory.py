from item import Item


class Accessory(Item):
    def __init__(self, name, sprite, buff):
        self.buff = buff
        super(Accessory, self).__init__(name, sprite)
     
    def __str__(self):
        pass
