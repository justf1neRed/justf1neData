 #!/bin/bash

RED='\033[0;31m'
GREEN='\033[0;32m'
ANSWERS=("${GREEN}YES" "${RED}NO")
echo "Ask me something..."
read 
echo -e "${ANSWERS[ $(( $RANDOM % ${#ANSWERS[@]} )) ]}"
