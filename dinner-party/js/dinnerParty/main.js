function main() {
  const guests = getGuests();
  const tables = {
    "Table 1": [],
    "Table 2": []
  };

  for (const guest of guests) {
    const table1Occupations = tables["Table 1"].map(g => g.occupation);
    if (table1Occupations.includes(guest.occupation)) {
      tables["Table 2"].push(guest);
    } else {
      tables["Table 1"].push(guest);
    }
  }
  
  for (const tableName of Object.keys(tables)) {
    const tableGuests = tables[tableName]; 
    console.log(tableName);
    for (const guest of tableGuests) {
      console.log(`${guest.name} (${guest.occupation}) ${guest.bio}`);
    }
  }
}


function getGuests() {
  return [
    {
      name: "Marilyn Monroe",
      occupation: "entertainer",
      bio: "(1926 - 1962) American actress, singer, model"
    },
    {
      name: "Abraham Lincoln",
      occupation: "politician",
      bio: "(1809 - 1865) US President during American civil war"
    },
    {
      name: "Martin Luther King",
      occupation: "activist",
      bio: "(1929 - 1968)  American civil rights campaigner"
    },
    {
      name: "Rosa Parks",
      occupation: "activist",
      bio: "(1913 - 2005)  American civil rights activist"
    },
    {
      name: "Peter Sellers",
      occupation: "entertainer",
      bio: "(1925 - 1980) British actor and comedian"
    },
    {
      name: "Alan Turing",
      occupation: "computer scientist",
      bio: "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    {
      name: "Admiral Grace Hopper",
      occupation: "computer scientist",
      bio: "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    {
      name: "Indira Gandhi",
      occupation: "politician",
      bio: "(1917 - 1984) Prime Minister of India 1966 - 1977",
    }
  ];
}

main();
