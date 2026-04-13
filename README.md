# Mars Rover

A terminal app for moving Rovers around on the surface of Mars.

I used an enum to represent rover instructions instead of strings, so only valid commands (L, R, M) can exist. This prevents invalid input and keeps the logic layer clean and type-safe

I created a Position class to group the rover’s coordinates and direction into a single object. This makes the code more readable and easier to extend in the future.