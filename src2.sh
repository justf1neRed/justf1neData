 #!/bin/bash

GREEN='\033[0;32m'

echo "Please enter IP:"
read ip
echo "Please enter domain name:"
read domain

echo "${ip}	${domain}" | sudo tee -a /etc/hosts
echo -e "${GREEN}Success!"

