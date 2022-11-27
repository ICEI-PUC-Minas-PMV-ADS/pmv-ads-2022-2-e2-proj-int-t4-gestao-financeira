import { linksRedirect } from "./links__redirect/index.js";

const closedMenu = () => {
  let containerItemsList = document.getElementById(
    "container__items__list__menu__side"
  );

  containerItemsList.style.animation = "normal animationClose 2s";

  setTimeout(() => {
    let containerPrincipal = document.getElementById("container__principal");
    containerPrincipal.removeChild(containerItemsList);
    containerPrincipal.prepend(menuHamburguer());
  }, 1800);
};

const menuLateral = () => {
  let containerItemsList = document.createElement("ul");
  containerItemsList.className = "container__items__list__menu__side";
  containerItemsList.id = "container__items__list__menu__side";

  let containerCloseButton = document.createElement("div");
  containerCloseButton.className = "container__close__button";

  let closeButton = document.createElement("h2");
  closeButton.innerText = "X";
  closeButton.className = "close__button";
  closeButton.addEventListener("click", closedMenu);

  containerCloseButton.append(closeButton);

  containerItemsList.prepend(containerCloseButton);

  linksRedirect.forEach((links) => {
    let containerItems = document.createElement("li");
    containerItems.className = "container__items__menu__side";

    let items = document.createElement("p");
    items.className = "items__menu__side";

    containerItems.addEventListener("click", () => {
      containerItemsList.innerHTML = "";
      let reload = document.createElement("div");
      reload.className = "reloading";

      containerItemsList.appendChild(reload);

      setTimeout(() => {
        window.location.href = links.url;

        let containerPrincipal = document.getElementById(
          "container__principal"
        );
        containerPrincipal.removeChild(containerItemsList);
        containerPrincipal.prepend(menuHamburguer());
        
      }, 2000);
    });

    containerItemsList.appendChild(containerItems);
    containerItems.appendChild(items);

    items.innerText = links.displayName;
  });

  return containerItemsList;
};

export const menuHamburguer = () => {
  let lineOne = document.createElement("div");
  let lineTwo = document.createElement("div");
  let lineThre = document.createElement("div");

  lineOne.className = "line__menu__hamburguer";
  lineTwo.className = "line__menu__hamburguer";
  lineThre.className = "line__menu__hamburguer";

  let containerMenu = document.createElement("div");
  containerMenu.className = "container__menu__hambuguer";

  containerMenu.appendChild(lineOne);
  containerMenu.appendChild(lineTwo);
  containerMenu.appendChild(lineThre);

  containerMenu.addEventListener("click", () => {
    let containerPrincipal = document.getElementById("container__principal");
    containerPrincipal.removeChild(containerMenu);
    containerPrincipal.prepend(menuLateral());
  });

  return containerMenu;
};
