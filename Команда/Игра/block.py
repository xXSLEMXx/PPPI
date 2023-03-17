import tools


class Block:
    def __init__(self, durability, sprite, effective_tool: tools.Tool):
        self.durability = durability
        self.sprite = sprite
        self.effective_tool = effective_tool

    def draw(self):
        pass

    def destroy(self):
        pass
       
         
    def __str__(self):
        pass
