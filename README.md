# DnDContainerProject 

## Main use case:
- Application that will show the contents of a PC's inventory
	- Can also support many containers i.e. bag, backpack, chest

## Future use cases: 
- Creating groups to manage items in all containers
- Visibility of containers
	- Visible to all players, Visible to owner and DM, visible to owner, visible to DM
- Quick trading of items between players
- Define container types
- Calculating weight/capacity/size based on character stats

## API services needed
- None

## Database design
- Containers
- Items
- Characters
- Container Assignments
- Item Assignments
- Users information for accounts 
- Container types
- item types?

# Starting Implementation:
- [ ] Database design
	- [ ] Create DB mockup to outline primary/foreign keys and relationships
- [ ] Get/Create/Update containers
	- [ ] Create APIs for GET/POST/PUT
	- [ ] Create Managers for Business functions
- [ ] Get/Create/Update items
	- [ ] Create APIs for GET/POST/PUT
	- [ ] Create Managers for Business functions
- [ ] Get/Create/Update Characters
	- [ ] Create APIs for GET/POST/PUT
	- [ ] Create Managers for Business functions
- [ ] Get/Create/Update container assignments
	- [ ] Create APIs for GET/POST/PUT
	- [ ] Create Managers for Business functions
- [ ] Get/Create/Update item assignments
	- [ ] Create APIs for GET/POST/PUT
	- [ ] Create Managers for Business functions
- [ ] Get/Create/Update User Information
	- [ ] Create APIs for GET/POST/PUT
	- [ ] Create Managers for Business functions
- [ ] Create frontend design
	- [ ] Create mockup of UX
	- [ ] Create possible user interactions/wants
- [ ] Add frontend functionality
	- [ ] Create atoms
	- [ ] Create molecules
	- [ ] Create organisms
	- [ ] Create templates