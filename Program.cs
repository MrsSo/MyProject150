using System.Diagnostics.Tracing;
using System.Net.Cache;

namespace Pokemon_API_Application;
class Pokemon;
  attr_accessor :level, :trainer;
  attr_reader :name, :type;

  def initialize(name, Type, level, trainer);
    @name = name;
    @type = Type;
    @level = levvel;
    @trainer = trainer;
    trainer.pokeman << self
  end  