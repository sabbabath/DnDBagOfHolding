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
- [x] Database design
	- [x] Create DB mockup to outline primary/foreign keys and relationships
- [x] Get/Create/Update containers
	- [x] Create APIs for GET/POST/PUT
	- [x] Create Managers for Business functions
- [x] Get/Create/Update items
	- [x] Create APIs for GET/POST/PUT
	- [x] Create Managers for Business functions
- [x] Get/Create/Update Characters
	- [x] Create APIs for GET/POST/PUT
	- [x] Create Managers for Business functions
- [x] Get/Create/Update container assignments
	- [x] Create APIs for GET/POST/PUT
	- [x] Create Managers for Business functions
- [x] Get/Create/Update item assignments
	- [x] Create APIs for GET/POST/PUT
	- [x] Create Managers for Business functions
- [x] Get/Create/Update User Information
	- [x] Create APIs for GET/POST/PUT
	- [x] Create Managers for Business functions
- [ ] Create frontend design
	- [ ] Create mockup of UX
	- [ ] Create possible user interactions/wants
- [ ] Add frontend functionality
	- [ ] Create atoms
	- [ ] Create molecules
	- [ ] Create organisms
	- [ ] Create templates